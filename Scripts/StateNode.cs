using Godot;

namespace DFAExample
{
	public class StateNode : Node
	{
		private Label nameLabel;
		private Label lastNodeLabel;
		private TextureRect texture;

        public override void _Ready()
        {
			nameLabel = GetNode<Label>("VBoxContainer/Name");
			lastNodeLabel = GetNode<Label>("VBoxContainer/LastNodeName");
			texture = GetNode<TextureRect>("VBoxContainer/TextureRect");
        
			nameLabel.Text = Name;
		}

		public void OnEntered(object[] args)
		{
			if (args != null && args.Length > 0)
			{
				if (args[0] is string previousNodeName)
				{
					lastNodeLabel.Text = previousNodeName;
				}
			}
            texture.SelfModulate = new Color(0f, 1f, 0f);
		}

		public void OnExited()
		{
            texture.SelfModulate = new Color(1f, 0f, 0f);
		}
	}
}