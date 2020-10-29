using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EasyCooperation.WeChat.ThirdPartyPlatforms.Enums
{
    /// <summary>
    /// 权限集枚举
    /// </summary>
    /// <summary>
    /// 全局返回码枚举
    /// </summary>
    /*
    *
    *#####how to get it！#####
    *
    *use browser ( but don't Internet Explorer) to open https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/Before_Develop/third_party_authority_instructions.html
    *open devTools of this page；switch to console
    *run this javascript code and copy result from new window
    *
        var symbolReg = new RegExp(/[\s|\~|`|\!|\@|\#|\$|\%|\^|\&|\*|\(|\)|\-|\_|\+|\=|\||\|\[|\]|\{|\}|\;|\:|\"|\'|\,|\<|\.|\>|\/|\?|\，|\。|\！|\：|\（|\）|\、\《|\》|\\]/g);
        function phraseToPascal(s) {
            var arr = s.split(symbolReg);
            for (var i = 0; i < arr.length; i++) {
                arr[i] = arr[i].charAt(0).toUpperCase() + arr[i].substring(1);
            }
            return arr.join("");
        };
        function m_KeyValueDescriptionAsCSharpEnum(k, v, d) {
            var enumStr = "";
            enumStr += "///<summary>\r\n";
            enumStr += "///" + d.replace(/\\n/g, '') + "\r\n";
            enumStr += "///</summary>" + "\r\n";
            enumStr += "[Description(\"" + d.replace(/[\\n|\"]/g, '') + "\")]" + "\r\n";
            var enumK = (v.replace(spaceTextReg, '') == "" ? phraseToPascal(d) : phraseToPascal(v)).replace(symbolReg, "");
            if (k < 0) {
                enumK = '_Negative' + (0 - k) + '_' + enumK;
            } else {
                enumK = '_' + k + '_' + enumK;
            }


            var enumV = k;
            enumStr += enumK + "=" + enumV + ',' + "\r\n";
            return enumStr;
        }
      
        var spaceTextReg = new RegExp(' ', 'g')
        var str = "";
        str += "public enum EnumFuncScopeCategory" + "\r\n";
        str += "{" + "\r\n";
        var x = document.getElementsByTagName("table")[0].rows;
        for (let item of x) {
            if (item === x[0]) {
                continue;
            }
            str += m_KeyValueDescriptionAsCSharpEnum(item.cells[0].innerHTML, item.cells[1].innerHTML, item.cells[2].innerHTML);
        }
        x = document.getElementsByTagName("table")[1].rows;
        for (let item of x) {
            if (item === x[0]) {
                continue;
            }
            str += m_KeyValueDescriptionAsCSharpEnum(item.cells[0].innerHTML, item.cells[1].innerHTML, item.cells[2].innerHTML);
        }
        str += "}" + "\r\n";
        myWindow = window.open('', '', 'width=200,height=100');
        myWindow.document.write("<xmp>" + str + "</xmp>");
        myWindow.focus();
    */
    public enum EnumFuncScopeCategory
    {
        ///<summary>
        ///帮助公众号接收用户消息，进行人工客服回复或自动回复
        ///</summary>
        [Description("帮助公众号接收用户消息，进行人工客服回复或自动回复")]
        _1_消息管理权限 = 1,
        ///<summary>
        ///帮助公众号获取用户信息，进行用户管理
        ///</summary>
        [Description("帮助公众号获取用户信息，进行用户管理")]
        _2_用户管理权限 = 2,
        ///<summary>
        ///帮助认证、设置公众号，进行帐号管理
        ///</summary>
        [Description("帮助认证、设置公众号，进行帐号管理")]
        _3_帐号服务权限 = 3,
        ///<summary>
        ///帮助公众号实现第三方网页服务和活动
        ///</summary>
        [Description("帮助公众号实现第三方网页服务和活动")]
        _4_网页服务权限 = 4,
        ///<summary>
        ///帮助公众号使用微信小店
        ///</summary>
        [Description("帮助公众号使用微信小店")]
        _5_微信小店权限 = 5,
        ///<summary>
        ///帮助公众号使用微信多客服
        ///</summary>
        [Description("帮助公众号使用微信多客服")]
        _6_微信多客服权限 = 6,
        ///<summary>
        ///帮助公众号进行群发和模板消息业务通知
        ///</summary>
        [Description("帮助公众号进行群发和模板消息业务通知")]
        _7_群发与通知权限 = 7,
        ///<summary>
        ///帮助公众号使用微信卡券
        ///</summary>
        [Description("帮助公众号使用微信卡券")]
        _8_微信卡券权限 = 8,
        ///<summary>
        ///帮助公众号使用微信扫一扫
        ///</summary>
        [Description("帮助公众号使用微信扫一扫")]
        _9_微信扫一扫权限 = 9,
        ///<summary>
        ///帮助公众号使用微信连WIFI
        ///</summary>
        [Description("帮助公众号使用微信连WIFI")]
        _10_微信连WIFI权限 = 10,
        ///<summary>
        ///帮助公众号管理多媒体素材，用于客服等业务
        ///</summary>
        [Description("帮助公众号管理多媒体素材，用于客服等业务")]
        _11_素材管理权限 = 11,
        ///<summary>
        ///帮助公众号使用微信摇周边
        ///</summary>
        [Description("帮助公众号使用微信摇周边")]
        _12_微信摇周边权限 = 12,
        ///<summary>
        ///帮助公众号使用微信门店
        ///</summary>
        [Description("帮助公众号使用微信门店")]
        _13_微信门店权限 = 13,
        ///<summary>
        ///帮助公众号使用自定义菜单
        ///</summary>
        [Description("帮助公众号使用自定义菜单")]
        _15_自定义菜单权限 = 15,
        ///<summary>
        ///帮助城市服务内的服务向用户发送消息，沉淀办事记录，展示页卡及办事结果页
        ///</summary>
        [Description("帮助城市服务内的服务向用户发送消息，沉淀办事记录，展示页卡及办事结果页")]
        _22_城市服务接口权限 = 22,
        ///<summary>
        ///帮助广告主进行微信广告的投放和管理
        ///</summary>
        [Description("帮助广告主进行微信广告的投放和管理")]
        _23_广告管理权限 = 23,
        ///<summary>
        ///帮助公众号绑定开放平台帐号，实现用户身份打通
        ///</summary>
        [Description("帮助公众号绑定开放平台帐号，实现用户身份打通")]
        _24_开放平台帐号管理权限 = 24,
        ///<summary>
        ///帮助公众号使用微信电子发票
        ///</summary>
        [Description("帮助公众号使用微信电子发票")]
        _26_微信电子发票权限 = 26,
        ///<summary>
        ///帮助公众号快速注册小程序
        ///</summary>
        [Description("帮助公众号快速注册小程序")]
        _27_快速注册小程序权限 = 27,
        ///<summary>
        ///可新增关联小程序，并对公众号已关联的小程序进行管理
        ///</summary>
        [Description("可新增关联小程序，并对公众号已关联的小程序进行管理")]
        _33_小程序管理权限 = 33,
        ///<summary>
        ///帮助公众号商家导入、更新、查询商品信息，从而在返佣商品推广等场景使用
        ///</summary>
        [Description("帮助公众号商家导入、更新、查询商品信息，从而在返佣商品推广等场景使用")]
        _34_微信商品库权限 = 34,
        ///<summary>
        ///为公众号提供用户卡路里同步、授权查询、兑换功能
        ///</summary>
        [Description("为公众号提供用户卡路里同步、授权查询、兑换功能")]
        _35_微信卡路里权限 = 35,
        ///<summary>
        ///帮助公众号将物品、订单、收藏等信息同步至好物圈，方便用户进行推荐
        ///</summary>
        [Description("帮助公众号将物品、订单、收藏等信息同步至好物圈，方便用户进行推荐")]
        _44_好物圈权限 = 44,
        ///<summary>
        ///帮助公众号使用微信一物一码功能
        ///</summary>
        [Description("帮助公众号使用微信一物一码功能")]
        _46_微信一物一码权限 = 46,
        ///<summary>
        ///帮助公众号完成授权、插卡及报销
        ///</summary>
        [Description("帮助公众号完成授权、插卡及报销")]
        _47_微信财政电子票据权限 = 47,
        ///<summary>
        ///帮助公众号配置对话能力，管理顾问、客户、标签和素材等
        ///</summary>
        [Description("帮助公众号配置对话能力，管理顾问、客户、标签和素材等")]
        _54_服务号对话权限 = 54,
        ///<summary>
        ///帮助公众号管理服务平台上购买的资源
        ///</summary>
        [Description("帮助公众号管理服务平台上购买的资源")]
        _66_服务平台管理权限 = 66,
        ///<summary>
        ///帮助小程序获取二维码，进行帐号管理
        ///</summary>
        [Description("帮助小程序获取二维码，进行帐号管理")]
        _17_帐号管理权限 = 17,
        ///<summary>
        ///帮助小程序进行功能开发与数据分析
        ///</summary>
        [Description("帮助小程序进行功能开发与数据分析")]
        _18_开发管理与数据分析权限 = 18,
        ///<summary>
        ///帮助小程序接收和发送客服消息
        ///</summary>
        [Description("帮助小程序接收和发送客服消息")]
        _19_客服消息管理权限 = 19,
        ///<summary>
        ///帮助小程序绑定开放平台帐号，实现用户身份打通
        ///</summary>
        [Description("帮助小程序绑定开放平台帐号，实现用户身份打通")]
        _25_开放平台帐号管理权限 = 25,
        ///<summary>
        ///帮助小程序设置名称、头像、简介、类目等基本信息
        ///</summary>
        [Description("帮助小程序设置名称、头像、简介、类目等基本信息")]
        _30_小程序基本信息设置权限 = 30,
        ///<summary>
        ///帮助小程序申请认证
        ///</summary>
        [Description("帮助小程序申请认证")]
        _31_小程序认证权限 = 31,
        ///<summary>
        ///为小程序提供用户卡路里同步、授权查询、兑换功能
        ///</summary>
        [Description("为小程序提供用户卡路里同步、授权查询、兑换功能")]
        _36_微信卡路里权限 = 36,
        ///<summary>
        ///帮助小程序创建附近地点，可设置小程序展示在“附近的小程序”入口中
        ///</summary>
        [Description("帮助小程序创建附近地点，可设置小程序展示在“附近的小程序”入口中")]
        _37_附近地点权限 = 37,
        ///<summary>
        ///用于代小程序管理插件的添加和使用
        ///</summary>
        [Description("用于代小程序管理插件的添加和使用")]
        _40_插件管理权限 = 40,
        ///<summary>
        ///帮助小程序将物品、订单、收藏等信息同步至好物圈，方便用户进行推荐
        ///</summary>
        [Description("帮助小程序将物品、订单、收藏等信息同步至好物圈，方便用户进行推荐")]
        _41_好物圈权限 = 41,
        ///<summary>
        ///帮助有快递配送需求的开发者，快速高效对接多家快递公司。对接后用户可通过微信服务通知接收实时快递配送状态，提升用户体验
        ///</summary>
        [Description("帮助有快递配送需求的开发者，快速高效对接多家快递公司。对接后用户可通过微信服务通知接收实时快递配送状态，提升用户体验")]
        _45_快递配送权限 = 45,
        ///<summary>
        ///帮助小程序完成授权、插卡及报销
        ///</summary>
        [Description("帮助小程序完成授权、插卡及报销")]
        _48_微信财政电子票据权限 = 48,
        ///<summary>
        ///帮助小程序管理小程序·云开发资源
        ///</summary>
        [Description("帮助小程序管理小程序·云开发资源")]
        _49_云开发管理权限 = 49,
        ///<summary>
        ///旨在解决餐饮、生鲜、超市等小程序的外卖配送需求，接入后小程序商家可通过统一的接口获得多家配送公司的配送服务，提高经营效率
        ///</summary>
        [Description("旨在解决餐饮、生鲜、超市等小程序的外卖配送需求，接入后小程序商家可通过统一的接口获得多家配送公司的配送服务，提高经营效率")]
        _51_即时配送权限 = 51,
        ///<summary>
        ///帮助有直播需求的小程序实现在小程序上直播边看边买的能力
        ///</summary>
        [Description("帮助有直播需求的小程序实现在小程序上直播边看边买的能力")]
        _52_小程序直播权限 = 52,
        ///<summary>
        ///帮助小程序推送小程序页面给搜索引擎，增加小程序页面在搜索的收录与曝光机会
        ///</summary>
        [Description("帮助小程序推送小程序页面给搜索引擎，增加小程序页面在搜索的收录与曝光机会")]
        _57_页面推送权限 = 57,
        ///<summary>
        ///帮助广告主进行微信广告的投放和管理
        ///</summary>
        [Description("帮助广告主进行微信广告的投放和管理")]
        _65_广告管理权限 = 65,
        ///<summary>
        ///帮助小程序管理服务平台上购买的资源
        ///</summary>
        [Description("帮助小程序管理服务平台上购买的资源")]
        _67_服务平台管理权限 = 67,
        ///<summary>
        ///支持对小商店商品及库存信息进行管理
        ///</summary>
        [Description("支持对小商店商品及库存信息进行管理")]
        _70_商品管理权限 = 70,
        ///<summary>
        ///支持对小商店订单及物流信息进行管理
        ///</summary>
        [Description("支持对小商店订单及物流信息进行管理")]
        _71_订单与物流管理权限 = 71,
    }
}
