using System;
using System.Collections.Generic;
using System.Text;

namespace YD.Data.EntityPrase
{
    /// <summary>
    /// ʵ����
    /// </summary>
    public class Item
    {
        /// <summary>
        /// ȡ�û������������
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ȡ�û�������ı���
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ȡ�û��������Ӧ��ʵ�����ͣ����������Ϊʵ��ʱ��Ч
        /// </summary>
        public string EntityName { get; set; }
        /// <summary>
        /// ȡ�û��������Ӧ��ö�����ͣ����������Ϊö��ʱ��Ч
        /// </summary>
        public string EnumName { get; set; }
        /// <summary>
        /// ȡ�û����������������
        /// </summary>
        public ItemType ItemType { get; set; }
        /// <summary>
        /// ȡ�û������������Ե�����
        /// </summary>
        public PropertyType PropertyType { get; set; }
        /// <summary>
        /// ȡ�û��������Ƿ����
        /// </summary>
        public bool Require { get; set; }
        /// <summary>
        /// ȡ�û������������
        /// </summary>
        public string Description { get; set; }
    }
}
