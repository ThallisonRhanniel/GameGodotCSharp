using Godot;
using System;

public partial class Espinhos : Area2D
{
    private void OnBodyEntered(Node body)
    {
        if (body.Name == "Player")
            CallDeferred(nameof(ReloadScene));
    }
    private void ReloadScene() => GetTree().ReloadCurrentScene();
}
