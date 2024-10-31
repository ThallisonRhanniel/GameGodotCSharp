using Godot;
using System;
using System.Numerics;
using Vector2 = Godot.Vector2;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	public const float Gravity = -400.0f;
	public Sprite2D sprite;

	// Obtém uma referência ao nó Sprite2D
	public override void _Ready()
	{
		// Obtém uma referência ao nó Sprite2D
		sprite = GetNode<Sprite2D>("Sprite2D");
		base._Ready();
	}
	
	// public override void _Input(InputEvent @event)
	// {
	// 	GD.Print(@event.AsText());
	// }

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;
		
		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_up") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}
		
		
		//Esse aqui parece funcionar melhor que o dado de exemplo pela godot
		if (Input.IsActionPressed("ui_right"))
		{
			velocity.X = Speed;
			sprite.FlipH = false;
		}
		else if (Input.IsActionPressed("ui_left"))
		{
			velocity.X = -Speed;
			sprite.FlipH = true;
		}
		else
		{
			velocity.X = 0;
		}
		
		
		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		// Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		// if (direction != Vector2.Zero)
		// {
		// 	sprite.FlipH = direction.X <= -1;
		// 	velocity.X = direction.X * Speed;
		// }
		// else
		// {
		// 	velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		// }

		Velocity = velocity;
		MoveAndSlide();
	}
}
