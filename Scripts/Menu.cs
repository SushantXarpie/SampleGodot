using Godot;
using System;

public class Menu : Node
{
    [Export] public NodePath PlayButtonPath;

    public override void _Ready()
    {
        var playButton = GetNode<Button>(PlayButtonPath);
        playButton.Connect("pressed", this, nameof(OnPlayButtonPressed));
    }

    private object OnPlayButtonPressed()
    {
        GD.Print("Play button pressed");
        return 5;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }
}


