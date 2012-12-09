using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Data;
using CalligraphySample.DataHelper;
using CalligraphySample.Entities;

namespace CalligraphySample.ViewModel
{
    public class CalligrapherViewModel
    {
        private CollectionViewSource _viewSource;

        public CollectionViewSource ViewSource
        {
            get { return _viewSource; }
            set { _viewSource = value; }
        }

        public CalligrapherViewModel()
        {
            _viewSource = new CollectionViewSource();
            ObservableCollection<Calligraphyer> calligraphyers = CalligrapherDataHelper.Load();
            _viewSource.Source = calligraphyers;
            //_viewSource.View.CollectionChanged += View_CollectionChanged;
        }

        //void View_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        //    {
        //        CalligrapherDataHelper.Insert((Calligraphyer)e.NewItems[0]);
        //    }
        //}

        public void AddCalligrapher()
        {
            Calligraphyer calligraphyer = new Calligraphyer();
            calligraphyer.Name = "书法家";
            calligraphyer.Description="简介";
            ((ObservableCollection<Calligraphyer>)_viewSource.Source).Add(calligraphyer);
        }

        public void Save()
        {
            CalligrapherDataHelper.Save((ObservableCollection<Calligraphyer>)_viewSource.Source);
        }
    }
}
