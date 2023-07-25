﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TodoItemAPP.Models;

namespace TodoItemAPP
{
    public class DivCode
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {   
        private List<DivCode> divCodes = new List<DivCode>();
        HttpClient client = new HttpClient();
        TodoitemsCollection todoitems = new TodoitemsCollection();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // CboIsComplete.Items.Add(new Dictionary<string, string> { });
            //CboIsComplete.Items.Add(new { Display = "True", Value = "1" });
            //CboIsComplete.Items.Add(new { Display = "False", Value = "0" });
            //CboIsComplete.DisplayMemberPath = "0";
            //CboIsComplete.Value
            divCodes.Add(new DivCode { Key = "True", Value = "1" });
            divCodes.Add(new DivCode { Key = "False", Value = "0" });
            CboIsComplete.ItemsSource = divCodes;
            CboIsComplete.DisplayMemberPath = "Key";

            DtpTodoDate.Culture = new System.Globalization.CultureInfo("ko-KR");

            client.BaseAddress = new System.Uri(" https://localhost:7164/");
            client.DefaultRequestHeaders.Accept.Add()
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
