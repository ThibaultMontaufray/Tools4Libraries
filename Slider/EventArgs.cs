using System;

namespace Tools4Libraries.Slider
{
    public class SliderTrackBarSeekEventArgs : EventArgs
    {
        public int Value { get; private set; }

        public SliderTrackBarSeekEventArgs(int value)
        {
            Value = value;
        }
    }

    public class SliderTrackBarValueChangedEventArgs : EventArgs
    {
        public int Value { get; private set; }
        public SliderTrackBar.SliderTrackBarValueChangeSource ChangeSource { get; private set; }

        public SliderTrackBarValueChangedEventArgs(int value, SliderTrackBar.SliderTrackBarValueChangeSource changeSource)
        {
            Value = value;
            ChangeSource = changeSource;
        }
    }

    public class SliderTrackBarValueChangingEventArgs : EventArgs
    {
        public int Value { get; private set; }
        public SliderTrackBar.SliderTrackBarValueChangeSource ChangeSource { get; private set; }
        public bool Cancel { get; set; }

        public SliderTrackBarValueChangingEventArgs(int value, SliderTrackBar.SliderTrackBarValueChangeSource changeSource)
        {
            Value = value;
            ChangeSource = changeSource;
            Cancel = false;
        }
    }
}
