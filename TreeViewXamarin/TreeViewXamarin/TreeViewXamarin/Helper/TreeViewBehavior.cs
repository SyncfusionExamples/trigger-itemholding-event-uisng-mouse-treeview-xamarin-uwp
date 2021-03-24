using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class TreeViewBehavior : Behavior<SfTreeView>
    {
        #region Overrides
        protected override void OnAttachedTo(SfTreeView bindable)
        {
            bindable.ItemHolding += Bindable_ItemHolding;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            bindable.ItemHolding -= Bindable_ItemHolding;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Call back

        private void Bindable_ItemHolding(object sender, ItemHoldingEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("TreeView ItemHold", (e.Node.Content as FileManager).ItemName, "Close");
        }

        #endregion
    }
}
