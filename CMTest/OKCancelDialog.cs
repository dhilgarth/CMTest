using Caliburn.Micro;

namespace CMTest
{
    public class OKCancelDialog : Screen
    {
        private bool _wasCanceled = true;

        public bool WasCanceled
        {
            get { return _wasCanceled; }
        }

        public void Cancel()
        {
            _wasCanceled = true;
            TryClose(false);
        }

        public void OK()
        {
            _wasCanceled = false;
            TryClose(true);
        }
    }
}
