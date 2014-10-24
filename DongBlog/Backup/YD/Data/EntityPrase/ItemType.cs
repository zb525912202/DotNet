namespace YD.Data.EntityPrase
{
    /// <summary>
    /// ʵ��ĳ�Ա����
    /// </summary>
    public enum ItemType
    {
        /// <summary>
        /// δ֪����
        /// </summary>
        Unknown,
        /// <summary>
        /// ����
        /// </summary>
        Int,
        /// <summary>
        /// ö��
        /// </summary>
        Enum,
        /// <summary>
        /// �ı�
        /// </summary>
        Text,
        /// <summary>
        /// ���ı�
        /// </summary>
        LongText,
        /// <summary>
        /// ����
        /// </summary>
        DateTime,
        /// <summary>
        /// ����
        /// </summary>
        Bool,
        /// <summary>
        /// ��������
        /// </summary>
        Bytes,
        /// <summary>
        /// ȫ��ͳһ��ʾ
        /// </summary>
        Guid,
        /// <summary>
        /// ����
        /// </summary>
        PrimaryKey,
        /// <summary>
        /// ���
        /// </summary>
        ForeignKey,
    }
}