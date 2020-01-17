﻿using OxyPlot;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSteakStocks.Plots.Classes
{
    public class TabItemPlot: BindableBase
    {
        public TabItemPlot(string name)
        {
            Name = name;
            //Points = new ObservableCollection<DataPoint>();
        }

    private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
            }
        }

        private PlotModel model = new PlotModel();
        public PlotModel Model { get { return model; } set { SetProperty(ref model, value); } }
    }
}
