using Godot;
using System;

public class Man : Node2D {
	private Random _random = new Random();
	private Vector2 _bounce = Vector2.Zero;

	[Export(PropertyHint.Range, "1, 2,")]
	private float _vStrength = 1.1f;
	[Export(PropertyHint.Range, "1, 2,")]
	private float _hStrength = 1.1f;
	[Export(PropertyHint.Range, "-0.5, 0.0,")]
	private float _maxRotLeft = -0.2f;
	[Export(PropertyHint.Range, "0, 0.5,")]
	private float _maxRotRight = 0.2f;
	[Export(PropertyHint.Range, "0, 1,")]
	private float _rotSpeed = 0.1f;

	// public override void _Ready() { }

	public override void _Process(float delta) {
		if (!_bounce.IsEqualApprox(Vector2.Zero)) {
			ContinueBounce();
			return;
		}

		_bounce.y = (_random.Next() % 5) - 2.5f;
		_bounce.x = (_random.Next() % 5) - 2.5f;
		ContinueBounce();
	}

	private void ContinueBounce() {
		Translate(_bounce);
		_bounce.y /= _vStrength;
		_bounce.x /= _hStrength;
		
		Rotate(_rotSpeed);

		if (Rotation < _maxRotLeft || Rotation > _maxRotRight) {
			_rotSpeed *= -1;
		}
	}
}
