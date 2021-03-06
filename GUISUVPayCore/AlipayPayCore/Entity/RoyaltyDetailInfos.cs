﻿namespace AlipayPayCore.Entity
{
    public class RoyaltyDetailInfos
    {
        /// <summary>
        ///分账序列号，表示分账执行的顺序，必须为正整数 
        /// </summary>
        [TradeField("serial_no", Length = 9, IsRequire = false)]
        public uint SerialNo
        { get; set; }
        /// <summary>
        ///接受分账金额的账户类型：  userId：支付宝账号对应的支付宝唯一用户号。  bankIndex：分账到银行账户的银行编号。目前暂时只支持分账到一个银行编号。 storeId：分账到门店对应的银行卡编号。 默认值为userId。
        /// </summary>
        [TradeField("trans_in_type", Length = 24, IsRequire = false)]
        public string TransInType
        { get; set; }
        /// <summary>
        ///分账批次号 分账批次号。 目前需要和转入账号类型为bankIndex配合使用
        /// </summary>
        [TradeField("batch_no", Length = 32, IsRequire = true)]
        public string BatchNo 
        { get; set; }
        /// <summary>
        ///商户分账的外部关联号，用于关联到每一笔分账信息，商户需保证其唯一性。 如果为空，该值则默认为“商户网站唯一订单号+分账序列号”
        /// </summary>
        [TradeField("out_relation_id", Length = 64, IsRequire = false)]
        public string OutRelationId 
        { get; set; }
        /// <summary>
        ///要分账的账户类型。 目前只支持userId：支付宝账号对应的支付宝唯一用户号。 默认值为userId。 
        /// </summary>
        [TradeField("trans_out_type", Length = 24, IsRequire = true)]
        public string TransOutType 
        { get; set; }
        /// <summary>
        ///如果转出账号类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。
        /// </summary>
        [TradeField("trans_out", Length = 16, IsRequire = true)]
        public string TransOut 
        { get; set; }
        /// <summary>
        ///如果转入账号类型为userId，本参数为接受分账金额的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  如果转入账号类型为bankIndex，本参数为28位的银行编号（商户和支付宝签约时确定）。 如果转入账号类型为storeId，本参数为商户的门店ID。
        /// </summary>
        [TradeField("trans_in", Length = 28, IsRequire = true)]
        public string TransIn 
        { get; set; }
        /// <summary>
        ///分账的金额，单位为元 
        /// </summary>
        [TradeField("amount", Length = 9, IsRequire = true)]
        public decimal Amount 
        { get; set; }
        /// <summary>
        ///分账描述信息 
        /// </summary>
        [TradeField(" desc", Length = 1000, IsRequire = false)]
        public string Desc 
        { get; set; }
        /// <summary>
        ///分账的比例，值为20代表按20%的比例分账
        /// </summary>
        [TradeField("amount_percentage", Length = 3, IsRequire = false)]
        public string AmountPercentage
        { get; set; }
    }
}