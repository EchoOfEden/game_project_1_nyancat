using Godot;
using System;

public partial class Sprite : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.Skew = 0;
		this.Rotation = 0;
		float windowWidth = (int)GetViewport().GetVisibleRect().Size.X;
		float windowHeight = (int)GetViewport().GetVisibleRect().Size.Y;
		float AMOUNT = 10;

		//ruch
		if (Input.IsKeyPressed(Key.W) || Input.IsKeyPressed(Key.Up))
		{
			this.Position += new Vector2(0,-AMOUNT);
			if (this.FlipH) this.Rotation = 0.1f;
			else this.Rotation = -0.1f;
		}

		if (Input.IsKeyPressed(Key.S)|| Input.IsKeyPressed(Key.Down))
		{
			this.Position += new Vector2(0,AMOUNT);
			if (this.FlipH) this.Rotation = -0.1f;
			else this.Rotation = 0.1f;
		}

		if (Input.IsKeyPressed(Key.A) || Input.IsKeyPressed(Key.Left))
		{
			if (!this.FlipH){
				this.FlipH = true;
			}
			
			

			this.Position += new Vector2(-AMOUNT, 0);
			this.Skew = -0.4f;
		}

		if (Input.IsKeyPressed(Key.D) || Input.IsKeyPressed(Key.Right))
		{
			if (this.FlipH){
				this.FlipH = false;
			}
			this.Position += new Vector2(AMOUNT, 0);
			this.Skew = 0.4f;
		} 


		//Zawijanie planszy
		if (this.Position.X < 0 )
		{
			this.Position = new Vector2(windowWidth, this.Position.Y);
		}

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
		}

	}
}
