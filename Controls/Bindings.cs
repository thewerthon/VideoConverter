namespace VideoConverter.Controls;

internal static class Bindings {

	public static void AddDataBinding(Control control, string property, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var binding = new Binding(property, source, member, false, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddTextBoxBinding(TextBox control, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var binding = new Binding("Text", source, member, false, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddNumberBoxBinding(NumericUpDown control, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var binding = new Binding("Value", source, member, false, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddCheckBoxBinding(CheckBox control, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var binding = new Binding("Checked", source, member, true, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddComboBoxBinding(ComboBox control, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var prop = control.DataSource == null ? "Text" : "SelectedValue";
		var binding = new Binding(prop, source, member, false, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddRadioGrouxBinding(RadioGroup control, object source, string member, DataSourceUpdateMode mode = DataSourceUpdateMode.OnPropertyChanged) {

		var binding = new Binding("Selected", source, member, false, mode);
		control.DataBindings.Add(binding);

	}

	public static void AddEnabledBinding(Control control, object source, string member, Func<object, bool> condition) {

		var binding = new Binding("Enabled", source, member, true, DataSourceUpdateMode.OnPropertyChanged);
		binding.Format += (sender, e) => e.Value = condition(e.Value!);
		control.DataBindings.Add(binding);

	}

}