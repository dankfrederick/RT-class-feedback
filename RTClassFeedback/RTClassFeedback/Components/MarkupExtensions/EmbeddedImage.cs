﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RTClassFeedback.Components.MarkupExtensions
{
    [ContentProperty (nameof(ResourceId))]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId))
                return null;
            return ImageSource.FromResource(ResourceId);
            // "RTClassFeedback.Components.Images.tempChart.PNG"
        }
    }
}
