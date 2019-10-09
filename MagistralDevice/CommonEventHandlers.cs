using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MagistralDevice.DataClasses;

namespace MagistralDevice
{
  internal static class CommonEventHandlers
  {
    public static void tbParamName_Leave(object sender, EventArgs e) {
      if( !(sender is TextBox nameBox) ) {
        return;
      }

      if( !(nameBox.Tag is List<dxParameter> parameterList) ) {
        return;
      }

      if( !(nameBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      int index = panel.GetRow(nameBox);
      // ReSharper disable once PossibleNullReferenceException
      parameterList[index].Name = nameBox.Text;
    }

    public static void tbParamValue_Leave(object sender, EventArgs e) {
      if( !(sender is TextBox valueBox) ) {
        return;
      }

      if( !(valueBox.Tag is List<dxParameter> parameterList) ) {
        return;
      }

      if( !(valueBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      int index = panel.GetRow(valueBox);
      if( int.TryParse(valueBox.Text, out int value) ) {
        // ReSharper disable once PossibleNullReferenceException
        parameterList[index].IntValue = value;
      }
    }

    public static void tbParamValue_KeyPress(object sender, KeyPressEventArgs e) {
      if( !(sender is TextBox valueBox) ) {
        return;
      }

      if( e != null && !int.TryParse(valueBox.Text, out int _) ) {
        e.KeyChar = (char)0;
      }
    }

    public static void chbParamValue_Click(object sender, EventArgs e) {
      if( !(sender is CheckBox valueBox) ) {
        return;
      }

      if( !(valueBox.Tag is List<dxParameter> parameterList) ) {
        return;
      }

      if( !(valueBox.Parent is TableLayoutPanel panel) ) {
        return;
      }

      int index = panel.GetRow(valueBox);
      // ReSharper disable once PossibleNullReferenceException
      parameterList[index].BoolValue = valueBox.Checked;
    }
  }
}
