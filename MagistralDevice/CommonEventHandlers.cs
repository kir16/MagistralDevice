using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MagistralDevice.DataClasses;
using MagistralDevice.Properties;

namespace MagistralDevice
{
  internal static class CommonEventHandlers
  {
    public static void tbValue_KeyPress(object sender, KeyPressEventArgs e) {
      if( !(sender is TextBox nameBox) ) {
        return;
      }


      if(e != null  && !string.IsNullOrEmpty(nameBox.Text) && !int.TryParse(nameBox.Text,out int dummy)) {
        e.KeyChar = (char)0;
      }
    }

    public static void chbValue_Click(object sender, EventArgs e) {
      if( !(sender is CheckBox valueBox) ) {
        return;
      }

      if( !(valueBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      if( !(panel.Tag is dxDeviceData data) ) {
        return;
      }

      if( data.Parameters == null ) {
        return;
      }

      int index = panel.GetRow(valueBox) - 1;

      if( data.Parameters[index] == null ) {
        return;
      }

      data.Parameters[index].BoolValue = valueBox.Checked;
    }

    public static void tbName_TextChanged(object sender, EventArgs e) {
      if( !(sender is TextBox nameBox) ) {
        return;
      }

      if( !(nameBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      if( !(panel.Tag is dxDeviceData data) ) {
        return;
      }

      if( data.Parameters == null ) {
        return;
      }

      int index = panel.GetRow(nameBox) - 1;

      if( data.Parameters[index] == null ) {
        return;
      }

      data.Parameters[index].Name = nameBox.Text;
    }

    public static void tbValue_TextChanged(object sender, EventArgs e) {
      if( !(sender is TextBox valueBox) ) {
        return;
      }

      if( !(valueBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      if( !(panel.Tag is dxDeviceData data) ) {
        return;
      }

      if( data.Parameters == null ) {
        return;
      }

      int index = panel.GetRow(valueBox) - 1;

      if( data.Parameters[index] == null ) {
        return;
      }

      if( int.TryParse(valueBox.Text, out int newValue) ) {
        data.Parameters[index].IntValue = newValue;
      }
    }

    public static void cbAccess_SelectedIndexChanged(object sender, EventArgs e) {
      if( Settings.Default == null ) {
        return;
      }
      if( !(sender is ComboBox accessBox) ) {
        return;
      }

      if( !(accessBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      if( !(panel.Tag is dxDeviceData data) ) {
        return;
      }

      if( data.Parameters == null ) {
        return;
      }

      int index = panel.GetRow(accessBox) - 1;

      if( data.Parameters[index] == null ) {
        return;
      }

      data.Parameters[index].Access = accessBox.SelectedIndex == 0 ? AccessLevel.Sys : AccessLevel.Usr;
    }
  }
}
