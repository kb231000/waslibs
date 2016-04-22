﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace AppStudio.Uwp.Controls
{
    public class TableStyle : ContainerStyle
    {
        public static readonly DependencyProperty BorderProperty = DependencyProperty.Register("Border", typeof(Thickness), typeof(TableStyle), new PropertyMetadata(new Thickness(0)));

        public Thickness Border
        {
            get { return (Thickness)GetValue(BorderProperty); }
            set { SetValue(BorderProperty, value); }
        }

        public static readonly DependencyProperty BorderForegroundProperty = DependencyProperty.Register("BorderForeground", typeof(Brush), typeof(TableStyle), new PropertyMetadata(null));

        public Brush BorderForeground
        {
            get { return (Brush)GetValue(BorderForegroundProperty); }
            set { SetValue(BorderForegroundProperty, value); }
        }

        public static readonly DependencyProperty ColumnWidthProperty = DependencyProperty.Register("ColumnWidth", typeof(GridLength), typeof(TableStyle), new PropertyMetadata(GridLength.Auto));

        public GridLength ColumnWidth
        {
            get { return (GridLength)GetValue(ColumnWidthProperty); }
            set { SetValue(ColumnWidthProperty, value); }
        }

        public static readonly DependencyProperty HorizontalAlignmentProperty = DependencyProperty.Register("HorizontalAlignment", typeof(HorizontalAlignment), typeof(TableStyle), new PropertyMetadata(Windows.UI.Xaml.HorizontalAlignment.Stretch));

        public HorizontalAlignment HorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalAlignmentProperty); }
            set { SetValue(HorizontalAlignmentProperty, value); }
        }

        public void Merge(TableStyle style)
        {
            if (style != null)
            {
                if (Border != style.Border)
                {
                    Border = style.Border;
                }
                if (ColumnWidth != style.ColumnWidth)
                {
                    ColumnWidth = style.ColumnWidth;
                }
                if (style.BorderForeground != null && BorderForeground != style.BorderForeground)
                {
                    BorderForeground = style.BorderForeground;
                }
                if (HorizontalAlignment != style.HorizontalAlignment)
                {
                    HorizontalAlignment = style.HorizontalAlignment;
                }
            }

            base.Merge(style);
        }
    }
}
