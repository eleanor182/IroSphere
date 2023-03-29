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

		[Header("�J���[�s�b�N�������摜��������")]
		[SerializeField, Tooltip("�摜�̐ݒ��Sprite(2D and UI)�ɕύX����̂����Y��Ȃ��I")]
		Sprite picture;
		public Sprite Picture => picture;

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

		[SerializeField, Tooltip("�`��^�C�v")]
		ShapeType shapeType = ShapeType.SPHERE;
		public ShapeType ShapeType => shapeType;

		[Header("�����z�u�̃m�[�h�̃p�����[�^�[�i���s���ύX�s�j")]

		[SerializeField, Range(1, 32), Tooltip("�F�������̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumH = 21;
		public int InitNodeNumH => initNodeNumH;


		[SerializeField, Range(1, 10), Tooltip("�ʓx�����̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumS = 7;
		public int InitNodeNumS => initNodeNumS;

		[SerializeField, Range(1, 19), Tooltip("���x�����̃m�[�h�̐��B���삪�d�����Ɗ������炱���������ĉ�����")]
		int initNodeNumL = 15;
		public int InitNodeNumL => initNodeNumL;

		[SerializeField, Range(0.0f, 1.0f), Tooltip("���S�����ɍs���ɏ]���ď��������邩�ǂ���")]
		float initNodeCenterSmall = 1;
		public float InitNodeCenterSmall => initNodeCenterSmall;

		[SerializeField, Range(0.01f, 1.0f), Tooltip("�����z�u�m�[�h�̃T�C�Y")]
		float initNodeSize = 0.02f;
		public float InitNodeSize => initNodeSize;

		[Header("�v���r���[�p�̃m�[�h�̃p�����[�^�[")]

		[SerializeField, Range(0.01f, 1.0f), Tooltip("�}�E�X�J�[�\�����Ă����̃m�[�h�̃T�C�Y�B���̃p�����[�^�[�͎��s���Ƀ��A���^�C���ɕύX�\�ł�")]
		float previewNodeSize = 0.4f;
		public float PreviewNodeSize => previewNodeSize;


		[Header("�N���b�N�Œǉ�����m�[�h�̃p�����[�^�[")]

		[SerializeField, Range(0.01f, 1.0f), Tooltip("�N���b�N���Ēu���鋅�̃T�C�Y�B���̃p�����[�^�[�͎��s���Ƀ��A���^�C���ɕύX�\�ł�")]
		float additiveNodeSize = 0.2f;
		public float AdditiveNodeSize => additiveNodeSize;

		[SerializeField, Range(1, 500), Tooltip("�N���b�N���Ēu���鋅�̍ő吔")]
		int maxAdditiveNodeNum = 200;
		public int MaxAdditiveNodeNum => maxAdditiveNodeNum;

		[Header("���[�h�������t�@�C���������ɓ����L�L�[")]
		[SerializeField]
		SaveData saveData;
		public SaveData SaveData => saveData;

		public SphereManager manager { get; set; }

		private void OnValidate()
		{
			if (!EditorApplication.isPlaying || manager == null)
				return;

			manager.ChangeNodeSize();
		}

	}
}