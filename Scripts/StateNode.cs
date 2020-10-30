using Godot;

namespace DFAExample
{
    public class StateNode : Node
    {
        private Label nameLabel;
        private Label lastNodeLabel;
		private Label timePassedLabel;
        private TextureRect texture;

        private float timePassed;

        public override void _Ready()
        {
            nameLabel = GetNode<Label>("VBoxContainer/Name");
            lastNodeLabel = GetNode<Label>("VBoxContainer/LastNodeName");
            timePassedLabel = GetNode<Label>("VBoxContainer/TimePassed");
			texture = GetNode<TextureRect>("VBoxContainer/TextureRect");

            nameLabel.Text = Name;
        }

        public void OnEntered(object[] args)
        {
			// Updates the label on the name of previous node
            if (args != null && args.Length > 0)
            {
                if (args[0] is string previousNodeName)
                {
                    lastNodeLabel.Text = previousNodeName;
                }
            }

			// Sets the color of node to green to indicate that it's active
            texture.SelfModulate = new Color(0f, 1f, 0f);
        }

        public void OnUpdate(float delta)
        {
			// Updates the label on the time the node has been active
			timePassed += delta;
			timePassedLabel.Text = timePassed.ToString("0.00");
        }

        public void OnExited()
        {
			// Set the color of node to red to indicate that it's inactive
            texture.SelfModulate = new Color(1f, 0f, 0f);
        }
    }
}