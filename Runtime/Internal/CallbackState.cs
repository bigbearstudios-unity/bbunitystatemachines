using System;

namespace BBUnity.StateMachines.Internal {

    /// <summary>
    /// A single State which acts the same as a State but 
    /// acts upon callbacks instead of interal methods. This is purely
    /// for internal purposes as a way to box the onTick, onEnter and onExit
    /// callbacks
    /// </summary>
    public class CallbackState : State {

        private Action _onTick = null;
        private Action _onEnter = null;
        private Action _onExit = null;

        public CallbackState() {  }
        public CallbackState(Action onTick = null, Action onEnter = null, Action onExit = null) {
            _onTick = onTick;
            _onEnter = onEnter;
            _onExit = onExit;
        }

        /// <summary>
        /// Called on each unity update
        /// </summary>
        public override void OnUpdate() {
            _onTick?.Invoke();
        }

        /// <summary>
        /// Called upon entering the state
        /// </summary>
        public override void OnEnter() {
            _onEnter?.Invoke();
        }

        /// <summary>
        /// Called upon exiting the state
        /// </summary>
        public override void OnExit() {
            _onExit?.Invoke();
        }
    }
}