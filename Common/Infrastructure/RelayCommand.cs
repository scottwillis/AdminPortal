using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Common {

	/// <summary>
	/// A command whose sole purpose is to relay its functionality to other objects by invoking delegates. The default return value for the CanExecute method is 'true'.
	/// </summary>
	public class RelayCommand<T> : ICommand {

		readonly Predicate<T> _canExecute;
		readonly Action<T> _execute;

		/// <summary>
		/// Initializes a new instance of the <see cref="RelayCommand&lt;T&gt;"/> class and the command can always be executed.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		public RelayCommand(Action<T> execute) : this(execute, null) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RelayCommand&lt;T&gt;"/> class.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		/// <param name="canExecute">The execution status logic.</param>
		public RelayCommand(Action<T> execute, Predicate<T> canExecute) {
			if (execute == null) throw new ArgumentNullException("execute");
			_execute = execute;
			_canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged {
			add {
				if (_canExecute != null) CommandManager.RequerySuggested += value;
			}
			remove {
				if (_canExecute != null) CommandManager.RequerySuggested -= value;
			}
		}

		[DebuggerStepThrough]
		public Boolean CanExecute(Object parameter) {
			return _canExecute == null ? true : _canExecute((T)parameter);
		}

		public void Execute(Object parameter) {
			_execute((T)parameter);
		}

	}

	/// <summary>
	/// A command whose sole purpose is to relay its functionality to other objects by invoking delegates. The default return value for the CanExecute method is 'true'.
	/// </summary>
	public class RelayCommand : ICommand {

		readonly Func<Boolean> _canExecute;
		readonly Action<object> _execute1;
		readonly Action<object, object> _execute2;
        private Action getData;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand&lt;T&gt;"/> class and the command can always be executed.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayCommand(Action<object> execute1) : this(execute1, null) {
		}

		public RelayCommand(Action<object, object> execute2) : this(execute2, null) {
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> execute1, Func<Boolean> canExecute) {
			if (execute1 == null) throw new ArgumentNullException("execute1");
			_execute1 = execute1;
			_canExecute = canExecute;
		}

		public RelayCommand(Action<object, object> execute2, Func<Boolean> canExecute) {
			if (execute2 == null) throw new ArgumentNullException("execute2");
			_execute2 = execute2;
			_canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged {
			add {
				if (_canExecute != null) CommandManager.RequerySuggested += value;
			}
			remove {
				if (_canExecute != null) CommandManager.RequerySuggested -= value;
			}
		}

		[DebuggerStepThrough]
		public Boolean CanExecute(Object parameter) {
			return _canExecute == null ? true : _canExecute();
		}

		public void Execute(Object arg) {
			_execute1(arg);
		}

		public void Execute(Object obj, Object arg) {
			_execute2(obj, arg);
		}

	}

}
