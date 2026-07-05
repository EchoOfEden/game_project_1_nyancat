using Godot;
using System;

public partial class Ghost : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float windowWidth = (int)GetViewport().GetVisibleRect().Size.X;
		float windowHeight = (int)GetViewport().GetVisibleRect().Size.Y;

		Sprite2D player = this.GetChild<Sprite2D>(0);
		Sprite2D ghost = this.GetChild<Sprite2D>(1);


		if (player.Position.X < 0 )
		{
			player.Position = new Vector2(windowWidth, player.Position.Y);
		}
		/*
		if (this.Position.X > windowWidth )
		{
			this.Position = new Vector2(0, this.Position.Y);
		}

		if (this.Position.Y < 0 )
		{
			this.Position = new Vector2(this.Position.X, windowHeight);
		}

		if (this.Position.Y > windowHeight )
		{
			this.Position = new Vector2(this.Position.X, 0);
		}*/
	}
}
