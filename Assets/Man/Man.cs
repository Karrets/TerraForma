using Godot;
using System;
using System.ComponentModel;

public class Man : Spatial {
	private Random _random = new Random();
	private Vector3 _bounce = Vector3.Zero;
	private float _speedMod = 1;

	[Export(PropertyHint.Range, "1, 2,")]
	private float _pDecay = 1.2f;
	[Export(PropertyHint.Range, "-0.5, 0.0,")]
	private float _maxRotLeft = -0.2f;
	[Export(PropertyHint.Range, "0, 0.5,")]
	private float _maxRotRight = 0.2f;
	[Export(PropertyHint.Range, "0, 1,")]
	private float _rotSpeed = 0.3f;

	public override void _Ready() {
		Translation = new Vector3(
			_random.Next(-12, 12) / 4f,
			0,
			_random.Next(-12, 12) / 4f);

		_speedMod +=  _random.Next(64) / 64f - 0.5f;
		_rotSpeed *= _speedMod;
	}

	public override void _Process(float delta) {
		if(_bounce.IsEqualApprox(Vector3.Zero)) InitNewBounce();

		RotateZ(_rotSpeed / 10);
		if (Rotation.z < _maxRotLeft || Rotation.z > _maxRotRight) _rotSpeed *= -1;
		
		Translate(_bounce);
		_bounce /= _pDecay;

		if (Translation.x > 3) Translation = new Vector3(6 - Translation.x, Translation.y, Translation.z);
		if (Translation.x < -3) Translation = new Vector3(6 + Translation.x, Translation.y, Translation.z);
		if (Translation.z > 0) Translation = new Vector3(Translation.x, Translation.y, 0);
		if (Translation.z < -4) Translation = new Vector3(Translation.x, Translation.y, -4);
	}

	private void InitNewBounce() {
		_bounce.x = (_random.Next(-32, 32) / 512f) * _speedMod;
		_bounce.z = (_random.Next(-32, 32) / 512f) * _speedMod;
	}
}
