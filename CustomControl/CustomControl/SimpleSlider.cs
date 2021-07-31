using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace CustomControl
{
    [TemplatePart(Name = ThumbPartName, Type = typeof(Thumb))]
    [TemplatePart(Name = RectanglePartName, Type = typeof(Rectangle))]
    public sealed class SimpleSlider : Control
    {
        private const string ThumbPartName = "PART_Thumb";
        private const string RectanglePartName = "PART_Rectangle";

        private Thumb _thumb;
        private Rectangle _rectangle;

        public SimpleSlider()
        {
            DefaultStyleKey = typeof(SimpleSlider);
        }

        // Ctrl + K, X -> NetFX30
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(SimpleSlider), new PropertyMetadata(0.0, OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var customSlider = (SimpleSlider)d;
            customSlider.UpdateControls();
        }

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Maximum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(SimpleSlider), new PropertyMetadata(100.0));

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minimum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(SimpleSlider), new PropertyMetadata(0.0));

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _thumb = GetTemplateChild(ThumbPartName) as Thumb;
            if (_thumb == null) return;
            _thumb.DragDelta += _thumb_DragDelta;

            _rectangle = GetTemplateChild(RectanglePartName) as Rectangle;
            SizeChanged += SimpleSlider_SizeChanged;
        }

        private void _thumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var pixelDiff = e.HorizontalChange;
            var currentLeft = Canvas.GetLeft(_thumb);

            if ((currentLeft + pixelDiff) < 0)
            {
                Value = 0;
            }
            else if ((currentLeft + pixelDiff + _thumb.ActualWidth) > ActualWidth)
            {
                Value = Maximum;
            }
            else
            {
                var totalSize = ActualWidth;
                var ratioDiff = pixelDiff / totalSize;
                var rangeSize = Maximum - Minimum;
                var rangeDiff = rangeSize * ratioDiff;
                Value += rangeDiff;
            }
        }

        private void SimpleSlider_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Math.Abs(e.NewSize.Width - e.PreviousSize.Width) > 0)
            {
                UpdateControls();
            }
        }

        private void UpdateControls()
        {
            double halfTheThumbWith;

            if (_thumb == null) return;

            halfTheThumbWith = _thumb.ActualWidth / 2;
            double totalSize = ActualWidth - halfTheThumbWith * 2;
            double ratio = totalSize / (Maximum - Minimum);

            if (_thumb == null) return;
            Canvas.SetLeft(_thumb, ratio * Value);

            if (_rectangle == null) return;
            _rectangle.Width = ratio * Value + halfTheThumbWith;
        }
    }
}
