using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Common {

	/// <summary>
	///   Contains helper methods for UI, so far just one for showing a waitcursor
	/// </summary>
	public static class UiServices {

		/// <summary>
		///   A value indicating whether the UI is currently busy
		/// </summary>
		private static bool IsBusy;

		/// <summary>
		/// Sets the busystate as busy.
		/// </summary>
		public static void SetBusyState() {
			SetBusyState(true);
		}

		/// <summary>
		/// Sets the busystate as busy.
		/// </summary>
		public static void SetNotBusyState() {
			IsBusy = false;
			if (!console_present) Mouse.OverrideCursor = Cursors.Arrow;
		}

		/// <summary>
		/// Sets the busystate to busy or not busy.
		/// </summary>
		/// <param name="busy">if set to <c>true</c> the application is now busy.</param>
		private static void SetBusyState(bool busy) {
			if (!console_present && busy != IsBusy) {
				IsBusy = busy;
				Mouse.OverrideCursor = busy ? Cursors.Wait : null;
				if (IsBusy) {
					new DispatcherTimer(TimeSpan.FromSeconds(0), DispatcherPriority.ApplicationIdle, dispatcherTimer_Tick, Application.Current.Dispatcher);
				}
			}
		}

		/// <summary>
		/// Handles the Tick event of the dispatcherTimer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private static void dispatcherTimer_Tick(object sender, EventArgs e) {
			var dispatcherTimer = sender as DispatcherTimer;
			if (dispatcherTimer != null) {
				SetBusyState(false);
				dispatcherTimer.Stop();
			}
		}

		private static bool? _console_present;
		public static bool console_present {
			get {
				if (_console_present == null) {
					_console_present = true;
					try { var window_height = Console.WindowHeight; }
					catch { _console_present = false; }
				}
				return _console_present.Value;
			}
		}

	}

}
