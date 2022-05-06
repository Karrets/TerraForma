using Godot;
using System;

public class Tree : Node2D
{
	private AnimatedSprite _sprites;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		_sprites = GetNode<AnimatedSprite> ("TreeSprites");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta) {
		_sprites.Frame = (_sprites.Frame + 1) % 4;
	}
}
