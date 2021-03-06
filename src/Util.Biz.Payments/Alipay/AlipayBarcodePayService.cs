﻿using Util.Biz.Payments.Alipay.Configs;
using Util.Biz.Payments.Core;

namespace Util.Biz.Payments.Alipay {
    /// <summary>
    /// 支付宝条码支付服务
    /// </summary>
    public class AlipayBarcodePayService : AlipayServiceBase {
        /// <summary>
        /// 初始化支付宝条码支付服务
        /// </summary>
        /// <param name="provider">支付宝配置提供器</param>
        public AlipayBarcodePayService( IAlipayConfigProvider provider ) : base( provider ){
        }

        /// <summary>
        /// 获取场景
        /// </summary>
        protected override string GetScene() {
            return "bar_code";
        }

        /// <summary>
        /// 获取请求方法
        /// </summary>
        protected override string GetMethod() {
            return "alipay.trade.pay";
        }

        /// <summary>
        /// 获取支付方式
        /// </summary>
        protected override PayWay GetPayWay() {
            return PayWay.AlipayBarcodePay;
        }
    }
}
