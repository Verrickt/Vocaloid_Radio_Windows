﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Advertising;
using System.Windows.Media;

// Developed by Deovandski Skibinski Junior
// Updated on 2/21/2014

namespace WPAppStudio.View
{
    public partial class VocaloidRadioWebsite : PhoneApplicationPage
    {

        // Contructor

        public VocaloidRadioWebsite()
        {
            InitializeComponent();
        }

        // AD Control Error - Log report is currently deactivated for faster load

        private void Ad1_ErrorOccurred(object sender, AdErrorEventArgs e)
        {
        }

        private void Ad1_Loaded(object sender, RoutedEventArgs e)
        {
        }

    }
}