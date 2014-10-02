namespace CMTest
{
    public class MainViewModel : OKCancelDialog
    {
        private string _boundData;

        public string BoundData
        {
            get { return _boundData; }
            set
            {
                if (_boundData == value)
                    return;

                _boundData = value;
                NotifyOfPropertyChange(() => BoundData);
                NotifyOfPropertyChange(() => BoundData2);
            }
        }

        public string BoundData2
        {
            get { return "Entered data: " + _boundData; }
        }
    }
}
