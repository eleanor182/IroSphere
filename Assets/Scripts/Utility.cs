using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
	/// <summary>
	/// 2��float�̍����\�����������ǂ����̔���
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	/// <returns></returns>
	public static bool IsEqual(float a, float b)
	{
		//1/256�����l�ȉ��͌덷�Ƃ��Đ؂�̂�
		return MathF.Abs(a - b) <= 0.004f;
	}

	/// <summary>
	/// �J���[��Photoshop�Ȃǂ̃p���b�g�ň�����16�i���`���ɕϊ�����
	/// </summary>
	/// <param name="color"></param>
	/// <returns></returns>
	public static string ColorTo16(Color color)
	{
		return ((int)(color.r * 255.0f)).ToString("x2") + ((int)(color.g * 255.0f)).ToString("x2") + ((int)(color.b * 255.0f)).ToString("x2");
	}

}
