using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/*
    Initialize a field/property of the type BrightnessController in a form or wherever you see fit
    BrightnessController brightnessController = new BrightnessController();

    // Change the brightness with this method with a monitor index and brightness value 0-100
    BrightnessController.MonitorArray[MONITOR_INDEX].SetBrightness(BRIGHTNESS);

    This was made in a very short time and not meant to be impressive or anything like that, i just needed a quick fix to dim my monitors
    when I'm up late nights and made this for my own use, but if anyone is interested here it is.
*/

/*
    Thanks to the anonymous paste bin user that posted this code and the notice above.
*/

namespace MonitorDimmer
{
    /// <summary>
    /// Rectangle
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    /// <summary>
    /// Monitor information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MONITORINFO
    {
        public uint size;
        public RECT monitor;
        public RECT work;
        public uint flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct PHYSICAL_MONITOR
    {
        public IntPtr hPhysicalMonitor;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPhysicalMonitorDescription;
    }

    public struct BrightnessValues
    {
        public uint Minimum;
        public uint Current;
        public uint Maximum;
    }

    /// <summary>
    /// Monitor information with handle.
    /// </summary>
    public class Monitor
    {
        /// <summary>
        /// Gets the monitor handle.
        /// </summary>
        /// <value>
        /// The monitor handle.
        /// </value>
        public IntPtr MonitorHandle { get; private set; }

        public uint PhysicalMonitorCount { get; private set; } = 1;

        public PHYSICAL_MONITOR[] PhysicalMonitorArray;

        public BrightnessValues[] BrightnessValues { get; private set; }

        #region Native Methods

        [DllImport("dxva2.dll", EntryPoint = "GetNumberOfPhysicalMonitorsFromHMONITOR")]
        public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, ref uint pdwNumberOfPhysicalMonitors);

        [DllImport("dxva2.dll", EntryPoint = "GetPhysicalMonitorsFromHMONITOR")]
        public static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        [DllImport("dxva2.dll", EntryPoint = "GetMonitorBrightness")]
        public static extern bool GetMonitorBrightness(IntPtr handle, ref uint minimumBrightness, ref uint currentBrightness, ref uint maxBrightness);

        [DllImport("dxva2.dll", EntryPoint = "SetMonitorBrightness")]
        public static extern bool SetMonitorBrightness(IntPtr handle, uint newBrightness);

        #endregion

        public Monitor(IntPtr monitorHandle)
        {
            this.MonitorHandle = monitorHandle;

            //if (!GetNumberOfPhysicalMonitorsFromHMONITOR(this.MonitorHandle, ref this.PhysicalMonitorCount))
            //{
            //    throw new Exception("Cannot get monitor count!");
            //}
            //this.PhysicalMonitorArray = new PHYSICAL_MONITOR[this.PhysicalMonitorCount];

            // Todo: Implement multi-physical display

            // This array will hold the IntPtr(s) we need to change brightness
            this.PhysicalMonitorArray = new PHYSICAL_MONITOR[this.PhysicalMonitorCount];
            this.BrightnessValues = new BrightnessValues[this.PhysicalMonitorCount];

            // Validate all physical monitors
            if (!GetPhysicalMonitorsFromHMONITOR(this.MonitorHandle, this.PhysicalMonitorCount, this.PhysicalMonitorArray))
            {
                throw new Exception("Cannot get physical monitor handle!");
            }

            // Get brightness values
            for (int i = 0; i < this.PhysicalMonitorCount; i++)
            {
                BrightnessValues brightness = new BrightnessValues();

                GetMonitorBrightness(
                    this.PhysicalMonitorArray[i].hPhysicalMonitor,
                    ref brightness.Minimum,
                    ref brightness.Current,
                    ref brightness.Maximum);

                this.BrightnessValues[i] = brightness;

                Console.WriteLine(
                    string.Format(
                        "hwId: {0}, Min: {1}, Max: {2}, Current: {3}",
                        this.PhysicalMonitorArray[i].hPhysicalMonitor,
                        brightness.Minimum,
                        brightness.Maximum,
                        brightness.Current));
            }
        }

        public void SetBrightness(int newValue)
        {
            newValue = Math.Min(newValue, Math.Max(0, newValue));

            for (int i = 0; i < this.PhysicalMonitorCount; i++)
            {
                var _maxValue = this.BrightnessValues[i].Maximum;
                var _minValue = this.BrightnessValues[i].Minimum;
                this.BrightnessValues[i].Current = (_maxValue - _minValue) * (uint)newValue / 100u + _minValue;

                SetMonitorBrightness(this.PhysicalMonitorArray[i].hPhysicalMonitor, this.BrightnessValues[i].Current);
            }
        }
    }

    public class BrightnessController : IDisposable
    {
        public static List<Monitor> MonitorArray { get; set; }

        public BrightnessController()
        {
            var monitors = GetMonitors();
        }

        public static Monitor[] GetMonitors()
        {
            // New List
            MonitorArray = new List<Monitor>();

            // Enumerate monitors
            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, MonitorEnum, IntPtr.Zero);

            // Return list
            return MonitorArray.ToArray();
        }

        #region Native Methods

        /// <summary>
        /// Monitor Enum Delegate
        /// </summary>
        /// <param name="hMonitor">A handle to the display monitor.</param>
        /// <param name="hdcMonitor">A handle to a device context.</param>
        /// <param name="lprcMonitor">A pointer to a RECT structure.</param>
        /// <param name="dwData">Application-defined data that EnumDisplayMonitors passes directly to the enumeration function.</param>
        /// <returns></returns>
        public delegate bool MonitorEnumDelegate(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);

        /// <summary>
        /// Enumerates through the display monitors.
        /// </summary>
        /// <param name="hdc">A handle to a display device context that defines the visible region of interest.</param>
        /// <param name="lprcClip">A pointer to a RECT structure that specifies a clipping rectangle.</param>
        /// <param name="lpfnEnum">A pointer to a MonitorEnumProc application-defined callback function.</param>
        /// <param name="dwData">Application-defined data that EnumDisplayMonitors passes directly to the MonitorEnumProc function.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumDelegate lpfnEnum, IntPtr dwData);

        /// <summary>
        /// Monitor Enum Delegate
        /// </summary>
        /// <param name="hMonitor">A handle to the display monitor.</param>
        /// <param name="hdcMonitor">A handle to a device context.</param>
        /// <param name="lprcMonitor">A pointer to a RECT structure.</param>
        /// <param name="dwData">Application-defined data that EnumDisplayMonitors passes directly to the enumeration function.</param>
        /// <returns></returns>
        public static bool MonitorEnum(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData)
        {
            MonitorArray.Add(new Monitor(hMonitor));

            return true;
        }

        [DllImport("dxva2.dll", EntryPoint = "DestroyPhysicalMonitors")]
        public static extern bool DestroyPhysicalMonitors(uint dwPhysicalMonitorArraySize, ref PHYSICAL_MONITOR[] pPhysicalMonitorArray);

        #endregion

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (MonitorArray.Count > 0)
                {
                    foreach (var monitor in MonitorArray)
                    {
                        DestroyPhysicalMonitors(monitor.PhysicalMonitorCount, ref monitor.PhysicalMonitorArray);
                    }
                }
            }
        }

    }
}