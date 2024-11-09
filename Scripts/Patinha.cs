using Godot;
using System;

public partial class Patinha : Area2D
{
    private void OnBodyEntered(Node body)
    {
        if (body.Name == "Player")
            CallDeferred(nameof(ChangeScene));
    }
    private void ChangeScene() => GetTree().ChangeSceneToFile("res://scenes/win.tscn");
    
}
