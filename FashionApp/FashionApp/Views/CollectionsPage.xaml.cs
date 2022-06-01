﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionsPage : ContentPage
    {
        public CollectionsPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Category> MyCollections { get => GetCollections(); }

        private List<Category> GetCollections()
        {
            var colList = new List<Category>();
            colList.Add(new Category { Image = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", Title = "MEN'S WRISTWATCHES" });
            colList.Add(new Category { Image = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", Title = "WOMEN'S MINI DRESSES" });
            colList.Add(new Category { Image = "https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png", Title = "WOMEN'S COATS" });
            return colList;
        }
    }

    public class Category
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
    }
}