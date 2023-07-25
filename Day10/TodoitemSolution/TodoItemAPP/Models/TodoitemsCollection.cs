using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace TodoItemAPP.Models
{
    public class TodoitemsCollection : ObservableCollection<Todoitem>
    {
        public void CopyFrom(IEnumerable<Todoitem> todoItems)
        {
            this.Items.Clear();

            foreach (Todoitem item in todoItems)
            {
                this.Items.Add(item);
            }

            this.OnCollectionChanged(new NotificationEventArgs(NotifyCollectionChangedAction.Reset));
    }
}
