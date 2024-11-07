using System.ComponentModel;

namespace VideoConverter.Controls;

public class RadioGroup : GroupBox {

	private int SelectedValue;
	private readonly List<RadioButton> RadioButtons = [];

	/// <summary>
	/// Occurs when the selected property value is changed.
	/// </summary>
	[Browsable(true)]
	[Description("Occurs when the selected property value is changed.")]
	public event EventHandler SelectedChanged = delegate { };

	/// <summary>
	/// Gets or sets the selected RadioButton as a nullable integer based on the control's Tag property.
	/// </summary>
	[Browsable(true)]
	[Description("Gets or sets the selected RadioButton as a nullable integer based on the control's Tag property.")]
	[DefaultValue(null)]
	public int Selected {

		get {

			return SelectedValue;

		}

		set {

			var rdb = RadioButtons.FirstOrDefault(radio => radio.Tag != null && int.TryParse(radio.Tag.ToString(), out var val) && val == value);
			if (rdb != null) { rdb.Checked = true; SelectedValue = value; }

		}

	}

	protected override void OnControlAdded(ControlEventArgs e) {

		base.OnControlAdded(e);
		RegisterControl(e.Control!);

	}

	private void RegisterControl(Control control) {

		if (control is RadioButton rdb) {

			rdb.CheckedChanged += RadioButton_CheckedChanged;
			RadioButtons.Add(rdb);

		} else {

			control.ControlAdded += (_, args) => RegisterControl(args.Control!);
			foreach (Control child in control.Controls) RegisterControl(child);

		}
	}

	public void RadioButton_CheckedChanged(object? sender, EventArgs e) {

		if (sender is RadioButton rdb && rdb.Checked && int.TryParse(rdb.Tag?.ToString(), out var val)) {

			SelectedValue = val;
			SelectedChanged(this, EventArgs.Empty);

		}

	}

}