using Godot;
using System;

public partial class NyanCat : Node
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
		Sprite2D ghostX = this.GetChild<Sprite2D>(1);
		Sprite2D ghostY = this.GetChild<Sprite2D>(2);
		Sprite2D ghostC = this.GetChild<Sprite2D>(3);

		ghostX.Visible = false;
		ghostY.Visible = false;
		ghostC.Visible = false;

		ghostX.FlipH = player.FlipH;
		ghostX.Skew = player.Skew;
		ghostX.Rotation = player.Rotation;

		ghostY.FlipH = player.FlipH;
		ghostY.Skew = player.Skew;
		ghostY.Rotation = player.Rotation;

		ghostC.FlipH = player.FlipH;
		ghostC.Skew = player.Skew;
		ghostC.Rotation = player.Rotation;

		double playerHeight = player.Texture.GetHeight() * 0.236;
		double playerWidth = player.Texture.GetWidth() * 0.236;

		if (player.Position.X < 0 + playerWidth/2 )
		{
			ghostX.Visible = true;
			ghostX.Position = new Vector2 ( player.Position.X + windowWidth ,player.Position.Y);
		}

		if (player.Position.X > windowWidth - playerWidth/2 )
		{
			ghostX.Visible = true;
			ghostX.Position = new Vector2 ( player.Position.X - windowWidth ,player.Position.Y);
		}

		if (player.Position.Y < 0 + playerHeight/2 )
		{
			ghostY.Visible = true;
			ghostY.Position = new Vector2 ( player.Position.X, player.Position.Y + windowHeight);
		}

		if (player.Position.Y > windowHeight - playerHeight/2 )
		{
			ghostY.Visible = true;
			ghostY.Position = new Vector2 ( player.Position.X, player.Position.Y - windowHeight);
		}

		//corner ghost
		if (player.Position.X < 0 + playerWidth/2 && player.Position.Y < 0 + playerHeight/2)
		{
			ghostC.Visible = true;
			ghostC.Position = new Vector2 (player.Position.X + windowWidth, player.Position.Y + windowHeight);
		}

		if (player.Position.X > windowWidth - playerWidth/2 && player.Position.Y < 0 + playerHeight/2)
		{
			ghostC.Visible = true;
			ghostC.Position = new Vector2 (player.Position.X - windowWidth, player.Position.Y + windowHeight);
		}

		if (player.Position.X < 0 + playerWidth/2 && player.Position.Y > windowHeight - playerHeight/2)
		{
			ghostC.Visible = true;
			ghostC.Position = new Vector2 (player.Position.X + windowWidth, player.Position.Y - windowHeight);
		}

		if (player.Position.X > windowWidth - playerWidth/2 && player.Position.Y > windowHeight - playerHeight/2)
		{
			ghostC.Visible = true;
			ghostC.Position = new Vector2 (player.Position.X - windowWidth, player.Position.Y - windowHeight);
		}


	}
}
