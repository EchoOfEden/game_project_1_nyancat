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
		float windowWidth = (int)GetViewport().GetVisibleRect().Size.X;
		float windowHeight = (int)GetViewport().GetVisibleRect().Size.Y;
		float AMOUNT = 10;

		//ruch
		if (Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0,-AMOUNT);
		}

		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0,AMOUNT);
		}

		if (Input.IsKeyPressed(Key.A))
		{
			if (!this.FlipH){
				this.FlipH = true;
			}
			
			

			this.Position += new Vector2(-AMOUNT, 0);
			this.Skew = -0.6f;
		}

		if (Input.IsKeyPressed(Key.D))
		{
			if (this.FlipH){
				this.FlipH = false;
			}
			this.Position += new Vector2(AMOUNT, 0);
			this.Skew = 0.6f;
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
