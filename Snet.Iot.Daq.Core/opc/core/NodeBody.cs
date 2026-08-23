namespace Snet.Iot.Daq.Core.opc.core
{
    /// <summary>
    /// 节点数据结构体
    /// </summary>
    public class NodeBody
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 是否为动态节点
        /// </summary>
        public bool Dynamic { get; set; }

        /// <summary>
        /// 访问级别；<br/>
        /// 1：只读；<br/>
        /// 2：只写；<br/>
        /// 3：读写；
        /// </summary>
        public byte AccessLevel { get; set; } = 3;

        /// <summary>
        /// 数据类型
        /// </summary>
        public string? DataType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 导出使用的地址
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 节点
        /// </summary>
        public List<NodeBody>? Nodes { get; set; }
    }
}