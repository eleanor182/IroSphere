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

}
