using System;
using System.Collections.Generic;
using System.Text;

namespace YD.Data.EntityPrase
{
    /// <summary>
    /// ʵ��
    /// </summary>
    public class Entity
    {
        private List<Item> _ItemList = new List<Item>();

        /// <summary>
        /// ȡ�û�����ʵ������
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ȡ�û�����ʵ�����
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ȡ�û�����ʵ��������ģ��
        /// </summary>
        public string Module { get; set; }
        /// <summary>
        /// ʵ�����������ݵļ���
        /// </summary>
        public List<Item> ItemList
        {
            get { return _ItemList; }
            set { _ItemList = value; }
        }

    }
}
