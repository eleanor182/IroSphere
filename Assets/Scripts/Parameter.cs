using IroSphere;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static IroSphere.SphereManager;

namespace IroSphere
{

	[CreateAssetMenu(menuName = "IroSphere/Parameter", fileName = "Parameter")]
	public class Parameter : ScriptableObject
	{


		[Header("�X�t�B�A�̉�]�A�ړ��A�g�k���\")]
		[SerializeField, Tooltip("�p�����x")]
		float rotateSpeed = 200.0f;
		public float RotateSpeed => rotateSpeed;
		
		[SerializeField, Tooltip("�p���x�u���[�L���O���\")]
		float rotateBrake = 3.0f;
		public float RotateBrake => rotateBrake;
		
		[SerializeField, Tooltip("�ړ����x")]
		float moveSpeed = 2.0f;
		public float MoveSpeed => moveSpeed;

		[SerializeField, Tooltip("�g�k���x")]
		float scaleSpeed = 2.0f;
		public float ScaleSpeed => scaleSpeed;

		[Header("�m�[�h�`��^�C�v")]
		[SerializeField, Tooltip("�`��^�C�v")]
		ShapeType shapeType = ShapeType.SPHERE;
		public ShapeType ShapeType => shapeType;

		[Header("�����z�u�m�[�h�̌��i���Q�[�����s���ύX�s���j")]

		[SerializeField, DisableEditOnPlay, Range(0, 32), Tooltip("�F�������̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumH = 21;
		public int InitNodeNumH => initNodeNumH;


		[SerializeField, DisableEditOnPlay, Range(0, 10), Tooltip("�ʓx�����̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumS = 7;
		public int InitNodeNumS => initNodeNumS;

		[SerializeField, DisableEditOnPlay, Range(0, 19), Tooltip("���x�����̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumL = 15;
		public int InitNodeNumL => initNodeNumL;

		[Header("�����z�u�̃m�[�h�̃T�C�Y")]

		[SerializeField, Range(0.0f, 1.0f), Tooltip("�����z�u�m�[�h�̃T�C�Y")]
		float initNodeSize = 0.02f;
		public float InitNodeSize => initNodeSize;

		[SerializeField, Range(0.0f, 1.0f), Tooltip("�X�t�B�A�̒��S�����ɍs���ɏ]���ď��������邩�ǂ���")]
		float initNodeCenterSmall = 1;
		public float InitNodeCenterSmall => initNodeCenterSmall;

		[Header("�v���r���[�p�m�[�h�̃T�C�Y")]

		[SerializeField, Range(0.0f, 1.0f), Tooltip("�v���r���[�m�[�h�̃T�C�Y")]
		float previewNodeSize = 0.4f;
		public float PreviewNodeSize => previewNodeSize;


		[Header("�N���b�N�Œǉ�����m�[�h�̃T�C�Y")]

		[SerializeField, Range(0.0f, 1.0f), Tooltip("�N���b�N���Ēu���鋅�̃T�C�Y")]
		float additiveNodeSize = 0.2f;
		public float AdditiveNodeSize => additiveNodeSize;

		[Header("�N���b�N�Œǉ�����m�[�h�̍ő吔�i���Q�[�����s���ύX�s���j")]
		[SerializeField, DisableEditOnPlay, Range(1, 1000), Tooltip("�N���b�N���Ēu���鋅�̍ő吔")]
		int maxAdditiveNodeNum = 200;
		public int MaxAdditiveNodeNum => maxAdditiveNodeNum;



		public SphereManager manager { get; set; }

		private void OnValidate()
		{
			if (!EditorApplication.isPlaying || manager == null)
				return;

			manager.ChangeNodeSize();
		}

	}
}