using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EasyCooperation.WeChat.Open.Enums
{
    /// <summary>
    /// 全局返回码枚举
    /// </summary>
    /*
    *
    *#####how to get it！#####
    *
    *use browser ( but don't Internet Explorer) to open https://developers.weixin.qq.com/doc/oplatform/Return_codes/Return_code_descriptions_new.html
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
        var x = $("#docContent table").rows;
        var spaceTextReg = new RegExp(' ', 'g')
        var str = "";
        str += "public enum EnumGlobalReturnCode" + "\r\n";
        str += "{" + "\r\n";
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

    public enum EnumGlobalReturnCode
    {
        ///<summary>
        ///系统繁忙，此时请开发者稍候再试
        ///</summary>
        [Description("系统繁忙，此时请开发者稍候再试")]
        _Negative1_SystemError = -1,
        ///<summary>
        ///请求成功
        ///</summary>
        [Description("请求成功")]
        _0_Ok = 0,
        ///<summary>
        ///POST参数非法
        ///</summary>
        [Description("POST参数非法")]
        _1003_POST参数非法 = 1003,
        ///<summary>
        ///商品id不存在
        ///</summary>
        [Description("商品id不存在")]
        _20002_商品id不存在 = 20002,
        ///<summary>
        ///获取 access_token 时 AppSecret 错误，或者 access_token 无效。请开发者认真比对 AppSecret  的正确性，或查看是否正在为恰当的公众号调用接口
        ///</summary>
        [Description("获取 access_toke 时 AppSecret 错误，或者 access_toke 无效。请开发者认真比对 AppSecret  的正确性，或查看是否正在为恰当的公众号调用接口")]
        _40001_InvalidCredentialAccessTokenIsInvalidOrNotLatest = 40001,
        ///<summary>
        ///不合法的凭证类型
        ///</summary>
        [Description("不合法的凭证类型")]
        _40002_InvalidGrantType = 40002,
        ///<summary>
        ///不合法的 OpenID ，请开发者确认 OpenID （该用户）是否已关注公众号，或是否是其他公众号的 OpenID
        ///</summary>
        [Description("不合法的 OpeID ，请开发者确认 OpeID （该用户）是否已关注公众号，或是否是其他公众号的 OpeID")]
        _40003_InvalidOpenid = 40003,
        ///<summary>
        ///不合法的媒体文件类型
        ///</summary>
        [Description("不合法的媒体文件类型")]
        _40004_InvalidMediaType = 40004,
        ///<summary>
        ///上传素材文件格式不对
        ///</summary>
        [Description("上传素材文件格式不对")]
        _40005_InvalidFileType = 40005,
        ///<summary>
        ///上传素材文件大小超出限制
        ///</summary>
        [Description("上传素材文件大小超出限制")]
        _40006_InvalidMeidaSize = 40006,
        ///<summary>
        ///不合法的媒体文件 id
        ///</summary>
        [Description("不合法的媒体文件 id")]
        _40007_InvalidMediaId = 40007,
        ///<summary>
        ///不合法的消息类型
        ///</summary>
        [Description("不合法的消息类型")]
        _40008_InvalidMessageType = 40008,
        ///<summary>
        ///图片尺寸太大
        ///</summary>
        [Description("图片尺寸太大")]
        _40009_InvalidImageSize = 40009,
        ///<summary>
        ///不合法的语音文件大小
        ///</summary>
        [Description("不合法的语音文件大小")]
        _40010_InvalidVoiceSize = 40010,
        ///<summary>
        ///不合法的视频文件大小
        ///</summary>
        [Description("不合法的视频文件大小")]
        _40011_InvalidVideoSize = 40011,
        ///<summary>
        ///不合法的缩略图文件大小
        ///</summary>
        [Description("不合法的缩略图文件大小")]
        _40012_InvalidThumbSize = 40012,
        ///<summary>
        ///不合法的appid
        ///</summary>
        [Description("不合法的appid")]
        _40013_InvalidAppid = 40013,
        ///<summary>
        ///不合法的 access_token ，请开发者认真比对 access_token 的有效性（如是否过期），或查看是否正在为恰当的公众号调用接口
        ///</summary>
        [Description("不合法的 access_toke ，请开发者认真比对 access_toke 的有效性（如是否过期），或查看是否正在为恰当的公众号调用接口")]
        _40014_InvalidAccessToken = 40014,
        ///<summary>
        ///不合法的菜单类型
        ///</summary>
        [Description("不合法的菜单类型")]
        _40015_InvalidMenuType = 40015,
        ///<summary>
        ///不合法的按钮个数
        ///</summary>
        [Description("不合法的按钮个数")]
        _40016_InvalidButtonSize = 40016,
        ///<summary>
        ///不合法的按钮类型
        ///</summary>
        [Description("不合法的按钮类型")]
        _40017_InvalidButtonType = 40017,
        ///<summary>
        ///不合法的按钮名字长度
        ///</summary>
        [Description("不合法的按钮名字长度")]
        _40018_InvalidButtonNameSize = 40018,
        ///<summary>
        ///不合法的按钮 KEY 长度
        ///</summary>
        [Description("不合法的按钮 KEY 长度")]
        _40019_InvalidButtonKeySize = 40019,
        ///<summary>
        ///不合法的按钮 URL 长度
        ///</summary>
        [Description("不合法的按钮 URL 长度")]
        _40020_InvalidButtonUrlSize = 40020,
        ///<summary>
        ///不合法的菜单版本号
        ///</summary>
        [Description("不合法的菜单版本号")]
        _40021_InvalidMenuVersion = 40021,
        ///<summary>
        ///不合法的子菜单级数
        ///</summary>
        [Description("不合法的子菜单级数")]
        _40022_InvalidSubMenuLevel = 40022,
        ///<summary>
        ///不合法的子菜单按钮个数
        ///</summary>
        [Description("不合法的子菜单按钮个数")]
        _40023_InvalidSubButtonSize = 40023,
        ///<summary>
        ///不合法的子菜单按钮类型
        ///</summary>
        [Description("不合法的子菜单按钮类型")]
        _40024_InvalidSubButtonType = 40024,
        ///<summary>
        ///不合法的子菜单按钮名字长度
        ///</summary>
        [Description("不合法的子菜单按钮名字长度")]
        _40025_InvalidSubButtonNameSize = 40025,
        ///<summary>
        ///不合法的子菜单按钮 KEY 长度
        ///</summary>
        [Description("不合法的子菜单按钮 KEY 长度")]
        _40026_InvalidSubButtonKeySize = 40026,
        ///<summary>
        ///不合法的子菜单按钮 URL 长度
        ///</summary>
        [Description("不合法的子菜单按钮 URL 长度")]
        _40027_InvalidSubButtonUrlSize = 40027,
        ///<summary>
        ///不合法的自定义菜单使用用户
        ///</summary>
        [Description("不合法的自定义菜单使用用户")]
        _40028_InvalidMenuApiUser = 40028,
        ///<summary>
        ///无效的 oauth_code
        ///</summary>
        [Description("无效的 oauth_code")]
        _40029_InvalidCode = 40029,
        ///<summary>
        ///不合法的 refresh_token
        ///</summary>
        [Description("不合法的 refresh_toke")]
        _40030_InvalidRefreshToken = 40030,
        ///<summary>
        ///不合法的 openid 列表
        ///</summary>
        [Description("不合法的 opeid 列表")]
        _40031_InvalidOpenidList = 40031,
        ///<summary>
        ///不合法的 openid 列表长度
        ///</summary>
        [Description("不合法的 opeid 列表长度")]
        _40032_InvalidOpenidListSize = 40032,
        ///<summary>
        ///不合法的请求字符，不能包含 \uxxxx 格式的字符
        ///</summary>
        [Description("不合法的请求字符，不能包含 uxxxx 格式的字符")]
        _40033_InvalidCharsetPleaseCheckYourRequestIfIncludeUxxxxWillCreateFail = 40033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40034_InvalidTemplateSize = 40034,
        ///<summary>
        ///不合法的参数
        ///</summary>
        [Description("不合法的参数")]
        _40035_InvalidArgsSize = 40035,
        ///<summary>
        ///不合法的 template_id 长度
        ///</summary>
        [Description("不合法的 template_id 长度")]
        _40036_InvalidTemplateIdSize = 40036,
        ///<summary>
        ///不合法的 template_id
        ///</summary>
        [Description("不合法的 template_id")]
        _40037_InvalidTemplateId = 40037,
        ///<summary>
        ///不合法的请求格式
        ///</summary>
        [Description("不合法的请求格式")]
        _40038_InvalidPackagingType = 40038,
        ///<summary>
        ///不合法的 URL 长度
        ///</summary>
        [Description("不合法的 URL 长度")]
        _40039_InvalidUrlSize = 40039,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40040_InvalidPluginToken = 40040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40041_InvalidPluginId = 40041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40042_InvalidPluginSession = 40042,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40043_InvalidFavType = 40043,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40044_InvalidSizeInLinkTitle = 40044,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40045_InvalidSizeInLinkDescription = 40045,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40046_InvalidSizeInLinkIconurl = 40046,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40047_InvalidSizeInLinkUrl = 40047,
        ///<summary>
        ///无效的url
        ///</summary>
        [Description("无效的url")]
        _40048_InvalidUrlDomain = 40048,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40049_InvalidScoreReportType = 40049,
        ///<summary>
        ///不合法的分组 id
        ///</summary>
        [Description("不合法的分组 id")]
        _40050_InvalidTimelineType = 40050,
        ///<summary>
        ///分组名字不合法
        ///</summary>
        [Description("分组名字不合法")]
        _40051_InvalidGroupName = 40051,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40052_InvalidActionName = 40052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40053_InvalidActionInfoPleaseCheckDocument = 40053,
        ///<summary>
        ///不合法的子菜单按钮 url 域名
        ///</summary>
        [Description("不合法的子菜单按钮 url 域名")]
        _40054_InvalidSubButtonUrlDomain = 40054,
        ///<summary>
        ///不合法的菜单按钮 url 域名
        ///</summary>
        [Description("不合法的菜单按钮 url 域名")]
        _40055_InvalidButtonUrlDomain = 40055,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40056_InvalidSerialCode = 40056,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40057_InvalidTabbarSize = 40057,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40058_InvalidTabbarNameSize = 40058,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40059_InvalidMsgId = 40059,
        ///<summary>
        ///删除单篇图文时，指定的 article_idx 不合法
        ///</summary>
        [Description("删除单篇图文时，指定的 article_idx 不合法")]
        _40060_InvalidArticleIdx = 40060,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40062_InvalidTitleSize = 40062,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40063_InvalidMessageExtSize = 40063,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40064_InvalidAppType = 40064,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40065_InvalidMsgStatus = 40065,
        ///<summary>
        ///不合法的 url ，递交的页面被sitemap标记为拦截
        ///</summary>
        [Description("不合法的 url ，递交的页面被sitemap标记为拦截")]
        _40066_InvalidUrl = 40066,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40067_InvalidTvid = 40067,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40068_ContainMailciousUrl = 40068,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40069_InvalidHardwareType = 40069,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40070_InvalidSkuInfo = 40070,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40071_InvalidCardType = 40071,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40072_InvalidLocationId = 40072,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40073_InvalidCardId = 40073,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40074_InvalidPayTemplateId = 40074,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40075_InvalidEncryptCode = 40075,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40076_InvalidColorId = 40076,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40077_InvalidScoreType = 40077,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40078_InvalidCardStatus = 40078,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40079_InvalidTime = 40079,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40080_InvalidCardExt = 40080,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40081_InvalidTemplateId = 40081,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40082_InvalidBannerPictureSize = 40082,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40083_InvalidBannerUrlSize = 40083,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40084_InvalidButtonDescSize = 40084,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40085_InvalidButtonUrlSize = 40085,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40086_InvalidSharelinkLogoSize = 40086,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40087_InvalidSharelinkDescSize = 40087,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40088_InvalidSharelinkTitleSize = 40088,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40089_InvalidPlatformId = 40089,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40090_InvalidRequestSourceBadClientIp = 40090,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40091_InvalidComponentTicket = 40091,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40092_InvalidRemarkName = 40092,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40093_NotCompletelyOkErrItemWillReturnLocationId1CheckYourRequiredFieldsInJson = 40093,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40094_InvalidComponentCredential = 40094,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40095_BadSourceOfCaller = 40095,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40096_InvalidBiztype = 40096,
        ///<summary>
        ///参数错误
        ///</summary>
        [Description("参数错误")]
        _40097_InvalidArgs = 40097,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40098_InvalidPoiid = 40098,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40099_InvalidCodeThisCodeHasConsumed = 40099,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40100_InvalidDateInfoMakeSureOldDateInfoTypeNewDateInfoTypeAmpAmpNewBeginTimeLtOldBeginTimeAmpAmpOldEndTimeLtNewEndTime = 40100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40101_MissingParameter = 40101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40102_InvalidIndustryId = 40102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40103_InvalidIndustryIndex = 40103,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40104_InvalidCategoryId = 40104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40105_InvalidViewType = 40105,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40106_InvalidUserName = 40106,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40107_InvalidCardId1CardStatusMustVerifyOk2ThisCardMustHaveLocationId = 40107,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40108_InvalidClientVersion = 40108,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40109_TooManyCodeSizeMustLt100 = 40109,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40110_HaveEmptyCode = 40110,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40111_HaveSameCode = 40111,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40112_CanNotSetBindOpenid = 40112,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40113_UnsupportedFileType = 40113,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40114_InvalidIndexValue = 40114,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40115_InvalidSessionFrom = 40115,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40116_InvalidCode = 40116,
        ///<summary>
        ///分组名字不合法
        ///</summary>
        [Description("分组名字不合法")]
        _40117_InvalidButtonMediaIdSize = 40117,
        ///<summary>
        ///media_id 大小不合法
        ///</summary>
        [Description("media_id 大小不合法")]
        _40118_InvalidSubButtonMediaIdSize = 40118,
        ///<summary>
        ///button 类型错误
        ///</summary>
        [Description("butto 类型错误")]
        _40119_InvalidUseButtonType = 40119,
        ///<summary>
        ///子 button 类型错误
        ///</summary>
        [Description("子 butto 类型错误")]
        _40120_InvalidUseSubButtonType = 40120,
        ///<summary>
        ///不合法的 media_id 类型
        ///</summary>
        [Description("不合法的 media_id 类型")]
        _40121_InvalidMediaTypeInViewLimited = 40121,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40122_InvalidCardQuantity = 40122,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40123_InvalidTaskId = 40123,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40124_TooManyCustomField = 40124,
        ///<summary>
        ///不合法的  AppID ，请开发者检查 AppID 的正确性，避免异常字符，注意大小写
        ///</summary>
        [Description("不合法的  AppID ，请开发者检查 AppID 的正确性，避免异常字符，注意大小写")]
        _40125_InvalidAppsecret = 40125,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40126_InvalidTextSize = 40126,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40127_InvalidUserCardStatusHintTheCardWasGivenToUserButMayBeDeletedOrExpiredOrSetUnavailable = 40127,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40128_InvalidMediaIdMustBeUploadedByApiCgiBinMaterialAddMaterial = 40128,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40129_InvalidScene = 40129,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40130_InvalidOpenidListSizeAtLeastTwoOpenid = 40130,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40131_OutOfLimitOfTicket = 40131,
        ///<summary>
        ///微信号不合法
        ///</summary>
        [Description("微信号不合法")]
        _40132_InvalidUsername = 40132,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40133_InvalidEncrytData = 40133,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40135_InvalidNotSupplyBonusCanNotChangeCardIdWhichSupplyBonusToBeNotSupply = 40135,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40136_InvalidUseDepositCodeModeMakeSureSkuQuantityGtDepositCodeQuantity = 40136,
        ///<summary>
        ///不支持的图片格式
        ///</summary>
        [Description("不支持的图片格式")]
        _40137_InvalidImageFormat = 40137,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40138_EmphasisWordCanNotBeFirstNeitherRemark = 40138,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40139_InvalidSubMerchantId = 40139,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40140_InvalidSubMerchantStatus = 40140,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40141_InvalidImageUrl = 40141,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40142_InvalidSharecardParameters = 40142,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40143_InvalidLeastCostInfoShouldBe0 = 40143,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40144_1MaybeShareCardListNumOrConsumeShareSelfNumTooBig2MaybeCardIdListAlsoHasSelfCardId3MaybeCardIdListHasManyDifferentCardId4MaybeBothConsumeShareSelfNumAndShareCardListNumBiggerThan0 = 40144,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40145_InvalidUpdateCanNotBothSetPayCellAndCenterCellInfoIncludeCenterTitleCenterSubTitleCenterUrl = 40145,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40146_InvalidOpenidCardMayBeMarkedByOtherUser = 40146,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40147_InvalidConsumeConsumeTimeOverrangingRestricts = 40147,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40148_InvalidFriendsCardType = 40148,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40149_InvalidUseTimeLimit = 40149,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40150_InvalidCardParameters = 40150,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40151_InvalidCardInfoTextPicHitAntispam = 40151,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40152_InvalidGroupId = 40152,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40153_SelfConsumeCellForFriendsCardMustNeedVerifyCode = 40153,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40154_InvalidVoipParameters = 40154,
        ///<summary>
        ///请勿添加其他公众号的主页链接
        ///</summary>
        [Description("请勿添加其他公众号的主页链接")]
        _40155_PleaseDonTContainOtherHomePageUrl = 40155,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40156_InvalidFaceRecognizeParameters = 40156,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40157_InvalidPictureHasNoFace = 40157,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40158_InvalidUseCustomCodeNeedBeFalse = 40158,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40159_InvalidLengthForPathOrTheDataIsNotJsonString = 40159,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40160_InvalidImageFile = 40160,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40161_ImageFileNotMatch = 40161,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40162_InvalidLifespan = 40162,
        ///<summary>
        ///oauth_code已使用
        ///</summary>
        [Description("oauth_code已使用")]
        _40163_CodeBeenUsed = 40163,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40164_InvalidIpNotInWhitelist = 40164,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40165_InvalidWeappPagepath = 40165,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40166_InvalidWeappAppid = 40166,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40167_ThereIsNoRelationWithPluginAppid = 40167,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40168_UnlinkedWeappCard = 40168,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40169_InvalidLengthForSceneOrTheDataIsNotJsonString = 40169,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40170_ArgsCountExceedCountLimit = 40170,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40171_ProductIdCanNotEmptyAndTheLengthCannotExceed32 = 40171,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40172_CanNotHaveSameProductId = 40172,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40173_ThereIsNoBindRelation = 40173,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40174_NotCardUser = 40174,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40175_InvalidMaterialId = 40175,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40176_InvalidTemplateId = 40176,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40177_InvalidProductId = 40177,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40178_InvalidSign = 40178,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40179_FunctionIsAdjustedRulesAreNotAllowedToAddOrUpdate = 40179,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40180_InvalidClientTmpToken = 40180,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40181_InvalidOpengid = 40181,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40182_InvalidPackId = 40182,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40183_InvalidProductAppidProductAppidShouldBindWithWxaAppid = 40183,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40184_InvalidUrlPath = 40184,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40185_InvalidAuthTokenOrAuthTokenIsExpired = 40185,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40186_InvalidDelegate = 40186,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40187_InvalidIp = 40187,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40188_InvalidScope = 40188,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40189_InvalidWidth = 40189,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40190_InvalidDelegateTime = 40190,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40191_InvalidPicUrl = 40191,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40192_InvalidAuthorInNews = 40192,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40193_InvalidRecommendLength = 40193,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40194_IllegalRecommend = 40194,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40195_InvalidShowNum = 40195,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40196_InvalidSmartmsgMediaId = 40196,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40197_InvalidSmartmsgMediaNum = 40197,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40198_InvalidDefaultMsgArticleSizeMustBeSameAsShowNum = 40198,
        ///<summary>
        ///运单 ID 不存在，未查到运单
        ///</summary>
        [Description("运单 ID 不存在，未查到运单")]
        _40199_WaybillIdNotFound = 40199,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40200_InvalidAccountType = 40200,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40201_InvalidCheckUrl = 40201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40202_InvalidCheckAction = 40202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40203_InvalidCheckOperator = 40203,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40204_CanNotDeleteWashOrRumorArticle = 40204,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40205_InvalidCheckKeywordsString = 40205,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40206_InvalidCheckBeginStamp = 40206,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40207_InvalidCheckAliveSeconds = 40207,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40208_InvalidCheckNotifyId = 40208,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40209_InvalidCheckNotifyMsg = 40209,
        ///<summary>
        ///pages 中的path参数不存在或为空
        ///</summary>
        [Description("pages 中的path参数不存在或为空")]
        _40210_InvalidCheckWxaPath = 40210,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40211_InvalidScopeData = 40211,
        ///<summary>
        ///paegs 当中存在不合法的query，query格式遵循URL标准，即k1=v1&amp;k2=v2
        ///</summary>
        [Description("paegs 当中存在不合法的query，query格式遵循URL标准，即k1=v1&amp;k2=v2")]
        _40212_InvalidQuery = 40212,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40213_InvalidHrefTag = 40213,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40214_InvalidHrefText = 40214,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40215_InvalidImageCount = 40215,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40216_InvalidDesc = 40216,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40217_InvalidVideoCount = 40217,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40218_InvalidVideoId = 40218,
        ///<summary>
        ///pages不存在或者参数为空
        ///</summary>
        [Description("pages不存在或者参数为空")]
        _40219_PagesIsEmpty = 40219,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40220_DataListIsEmpty = 40220,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40221_InvalidContentEncoding = 40221,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _40222_InvalidRequestIdcDomain = 40222,
        ///<summary>
        ///缺少 access_token 参数
        ///</summary>
        [Description("缺少 access_toke 参数")]
        _41001_AccessTokenMissing = 41001,
        ///<summary>
        ///缺少 appid 参数
        ///</summary>
        [Description("缺少 appid 参数")]
        _41002_AppidMissing = 41002,
        ///<summary>
        ///缺少 refresh_token 参数
        ///</summary>
        [Description("缺少 refresh_toke 参数")]
        _41003_RefreshTokenMissing = 41003,
        ///<summary>
        ///缺少 secret 参数
        ///</summary>
        [Description("缺少 secret 参数")]
        _41004_AppsecretMissing = 41004,
        ///<summary>
        ///缺少多媒体文件数据，传输素材无视频或图片内容
        ///</summary>
        [Description("缺少多媒体文件数据，传输素材无视频或图片内容")]
        _41005_MediaDataMissing = 41005,
        ///<summary>
        ///缺少 media_id 参数
        ///</summary>
        [Description("缺少 media_id 参数")]
        _41006_MediaIdMissing = 41006,
        ///<summary>
        ///缺少子菜单数据
        ///</summary>
        [Description("缺少子菜单数据")]
        _41007_SubMenuDataMissing = 41007,
        ///<summary>
        ///缺少 oauth code
        ///</summary>
        [Description("缺少 oauth code")]
        _41008_MissingCode = 41008,
        ///<summary>
        ///缺少 openid
        ///</summary>
        [Description("缺少 opeid")]
        _41009_MissingOpenid = 41009,
        ///<summary>
        ///缺失 url 参数
        ///</summary>
        [Description("缺失 url 参数")]
        _41010_MissingUrl = 41010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41011_MissingRequiredFieldsPleaseCheckDocumentAndRequestJson = 41011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41012_MissingCardId = 41012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41013_MissingCode = 41013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41014_MissingTicketClass = 41014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41015_MissingShowTime = 41015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41016_MissingScreeningRoom = 41016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41017_MissingSeatNumber = 41017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41018_MissingComponentAppid = 41018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41019_MissingPlatformSecret = 41019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41020_MissingPlatformTicket = 41020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41021_MissingComponentAccessToken = 41021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41024_MissingDisplayField = 41024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41025_PoiListEmpty = 41025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41026_MissingImageListInfoTextMaybeEmpty = 41026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41027_MissingVoipCallKey = 41027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41028_InvalidFormId = 41028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41029_FormIdUsedCountReachLimit = 41029,
        ///<summary>
        ///page路径不正确，需要保证在现网版本小程序中存在，与app.json保持一致
        ///</summary>
        [Description("page路径不正确，需要保证在现网版本小程序中存在，与app.jso保持一致")]
        _41030_InvalidPage = 41030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41031_TheFormIdHaveBeenBlocked = 41031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41032_NotAllowToSendMessageWithSubmittedFormIdForPunishment = 41032,
        ///<summary>
        ///只允许通过api创建的小程序使用
        ///</summary>
        [Description("只允许通过api创建的小程序使用")]
        _41033_InvaidRegisterType = 41033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41034_NotAllowToSendMessageWithSubmittedFormIdForPunishment = 41034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41035_NotAllowToSendMessageWithPrepayIdForPunishment = 41035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41036_AppidAdCid = 41036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41037_AppidAdMchAppid = 41037,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _41038_AppidPosType = 41038,
        ///<summary>
        ///access_token 超时，请检查 access_token 的有效期，请参考基础支持 - 获取 access_token 中，对  access_token 的详细机制说明
        ///</summary>
        [Description("access_toke 超时，请检查 access_toke 的有效期，请参考基础支持 - 获取 access_toke 中，对  access_toke 的详细机制说明")]
        _42001_AccessTokenExpired = 42001,
        ///<summary>
        ///refresh_token 超时
        ///</summary>
        [Description("refresh_toke 超时")]
        _42002_RefreshTokenExpired = 42002,
        ///<summary>
        ///oauth_code 超时
        ///</summary>
        [Description("oauth_code 超时")]
        _42003_CodeExpired = 42003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _42004_PluginTokenExpired = 42004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _42005_ApiUsageExpired = 42005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _42006_ComponentAccessTokenExpired = 42006,
        ///<summary>
        ///用户修改微信密码， accesstoken 和 refreshtoken 失效，需要重新授权
        ///</summary>
        [Description("用户修改微信密码， accesstoke 和 refreshtoke 失效，需要重新授权")]
        _42007_AccessTokenAndRefreshTokenException = 42007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _42008_VoipCallKeyExpired = 42008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _42009_ClientTmpTokenExpired = 42009,
        ///<summary>
        ///需要 GET 请求
        ///</summary>
        [Description("需要 GET 请求")]
        _43001_RequireGETMethod = 43001,
        ///<summary>
        ///需要 POST 请求
        ///</summary>
        [Description("需要 POST 请求")]
        _43002_RequirePOSTMethod = 43002,
        ///<summary>
        ///需要 HTTPS 请求
        ///</summary>
        [Description("需要 HTTPS 请求")]
        _43003_RequireHttps = 43003,
        ///<summary>
        ///需要接收者关注
        ///</summary>
        [Description("需要接收者关注")]
        _43004_RequireSubscribe = 43004,
        ///<summary>
        ///需要好友关系
        ///</summary>
        [Description("需要好友关系")]
        _43005_RequireFriendRelations = 43005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43006_RequireNotBlock = 43006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43007_RequireBizuserAuthorize = 43007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43008_RequireBizPayAuth = 43008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43009_CanNotUseCustomCodeNeedAuthorize = 43009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43010_CanNotUseBalanceNeedAuthorize = 43010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43011_CanNotUseBonusNeedAuthorize = 43011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43012_CanNotUseCustomUrlNeedAuthorize = 43012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43013_CanNotUseShakeCardNeedAuthorize = 43013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43014_RequireCheckAgent = 43014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43015_RequireAuthorizeByWechatTeamToUseThisFunction = 43015,
        ///<summary>
        ///小程序未认证
        ///</summary>
        [Description("小程序未认证")]
        _43016_RequireVerify = 43016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43017_RequireLocationId = 43017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43018_CodeHasNoBeenMark = 43018,
        ///<summary>
        ///需要将接收者从黑名单中移除
        ///</summary>
        [Description("需要将接收者从黑名单中移除")]
        _43019_RequireRemoveBlacklist = 43019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43100_ChangeTemplateTooFrequently = 43100,
        ///<summary>
        ///用户拒绝接受消息，如果用户之前曾经订阅过，则表示用户取消了订阅关系
        ///</summary>
        [Description("用户拒绝接受消息，如果用户之前曾经订阅过，则表示用户取消了订阅关系")]
        _43101_UserRefuseToAcceptTheMsg = 43101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43102_TheTempalteIsNotSubscriptiontype = 43102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43103_TheApiOnlyCanCancelTheSubscription = 43103,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43104_ThisAppidDoesNotHavePermission = 43104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43105_NewsHasNoBindingRelationWithTemplateId = 43105,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _43106_NotAllowToAddTemplateForPunishment = 43106,
        ///<summary>
        ///多媒体文件为空
        ///</summary>
        [Description("多媒体文件为空")]
        _44001_EmptyMediaData = 44001,
        ///<summary>
        ///POST 的数据包为空
        ///</summary>
        [Description("POST 的数据包为空")]
        _44002_EmptyPostData = 44002,
        ///<summary>
        ///图文消息内容为空
        ///</summary>
        [Description("图文消息内容为空")]
        _44003_EmptyNewsData = 44003,
        ///<summary>
        ///文本消息内容为空
        ///</summary>
        [Description("文本消息内容为空")]
        _44004_EmptyContent = 44004,
        ///<summary>
        ///空白的列表
        ///</summary>
        [Description("空白的列表")]
        _44005_EmptyListSize = 44005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _44006_EmptyFileData = 44006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _44007_RepeatedMsgId = 44007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _44997_ImageUrlSizeOutOfLimit = 44997,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _44998_KeywordStringMediaSizeOutOfLimit = 44998,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _44999_KeywordsListSizeOutOfLimit = 44999,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45000_MsgIdSizeOutOfLimit = 45000,
        ///<summary>
        ///多媒体文件大小超过限制
        ///</summary>
        [Description("多媒体文件大小超过限制")]
        _45001_MediaSizeOutOfLimit = 45001,
        ///<summary>
        ///消息内容超过限制
        ///</summary>
        [Description("消息内容超过限制")]
        _45002_ContentSizeOutOfLimit = 45002,
        ///<summary>
        ///标题字段超过限制
        ///</summary>
        [Description("标题字段超过限制")]
        _45003_TitleSizeOutOfLimit = 45003,
        ///<summary>
        ///描述字段超过限制
        ///</summary>
        [Description("描述字段超过限制")]
        _45004_DescriptionSizeOutOfLimit = 45004,
        ///<summary>
        ///链接字段超过限制
        ///</summary>
        [Description("链接字段超过限制")]
        _45005_UrlSizeOutOfLimit = 45005,
        ///<summary>
        ///图片链接字段超过限制
        ///</summary>
        [Description("图片链接字段超过限制")]
        _45006_PicurlSizeOutOfLimit = 45006,
        ///<summary>
        ///语音播放时间超过限制
        ///</summary>
        [Description("语音播放时间超过限制")]
        _45007_PlaytimeOutOfLimit = 45007,
        ///<summary>
        ///图文消息超过限制
        ///</summary>
        [Description("图文消息超过限制")]
        _45008_ArticleSizeOutOfLimit = 45008,
        ///<summary>
        ///接口调用超过限制
        ///</summary>
        [Description("接口调用超过限制")]
        _45009_ReachMaxApiDailyQuotaLimit = 45009,
        ///<summary>
        ///创建菜单个数超过限制
        ///</summary>
        [Description("创建菜单个数超过限制")]
        _45010_CreateMenuLimit = 45010,
        ///<summary>
        ///API 调用太频繁，请稍候再试
        ///</summary>
        [Description("API 调用太频繁，请稍候再试")]
        _45011_ApiMinuteQuotaReachLimitMustSlowerRetryNextMinute = 45011,
        ///<summary>
        ///模板大小超过限制
        ///</summary>
        [Description("模板大小超过限制")]
        _45012_TemplateSizeOutOfLimit = 45012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45013_TooManyTemplateArgs = 45013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45014_TemplateMessageSizeOutOfLimit = 45014,
        ///<summary>
        ///回复时间超过限制
        ///</summary>
        [Description("回复时间超过限制")]
        _45015_ResponseOutOfTimeLimitOrSubscriptionIsCanceled = 45015,
        ///<summary>
        ///系统分组，不允许修改
        ///</summary>
        [Description("系统分组，不允许修改")]
        _45016_CanTModifySysGroup = 45016,
        ///<summary>
        ///分组名字过长
        ///</summary>
        [Description("分组名字过长")]
        _45017_CanTSetGroupNameTooLongSysGroup = 45017,
        ///<summary>
        ///分组数量超过上限
        ///</summary>
        [Description("分组数量超过上限")]
        _45018_TooManyGroupNowNoNeedToAddNew = 45018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45019_TooManyOpenidPleaseInputLess = 45019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45020_TooManyImagePleaseInputLess = 45020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45021_SomeArgumentMayBeOutOfLengthLimitPleaseCheckDocumentAndRequestJson = 45021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45022_BonusIsOutOfLimit = 45022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45023_BalanceIsOutOfLimit = 45023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45024_RankTemplateNumberIsOutOfLimit = 45024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45025_PoiidCountIsOutOfLimit = 45025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45026_TemplateNumExceedsLimit = 45026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45027_TemplateConflictWithIndustry = 45027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45028_HasNoMasssendQuota = 45028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45029_QrcodeCountOutOfLimit = 45029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45030_LimitCardidNotSupportThisFunction = 45030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45031_StockIsOutOfLimit = 45031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45032_NotInnerIpForSpecialAcctInWhiteList = 45032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45033_UserGetCardNumIsOutOfGetLimit = 45033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45034_MediaFileCountIsOutOfLimit = 45034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45035_AccessClientipIsNotRegisteredNotInIpWhiteList = 45035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45036_UserReceiveAnnouncementLimit = 45036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45037_UserOutOfTimeLimitOrNeverTalkedInTempsession = 45037,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45038_UserSubscribedCannotUseTempsessionApi = 45038,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45039_CardListSizeOutOfLimit = 45039,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45040_ReachMaxMonthlyQuotaLimit = 45040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45041_ThisCardReachTotalSkuQuantityLimit = 45041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45042_LimitCardTypeThisCardTypeCanNOTCreateBySubMerchant = 45042,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45043_CanNotSetShareFriendsTrueBecauseHasNoAbstractOrTextImgListHasNoImgOrImageUrlNotValid = 45043,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45044_IconUrlSizeInAbstractIsOutOfLimit = 45044,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45045_UnauthorizedFriendsCardPleaseContactAdministrator = 45045,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45046_OperateFieldConflictCenterCellPayCellSelfConsumeCellConflict = 45046,
        ///<summary>
        ///客服接口下行条数超过上限
        ///</summary>
        [Description("客服接口下行条数超过上限")]
        _45047_OutOfResponseCountLimit = 45047,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45048_MenuUseInvalidType = 45048,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45049_IvrUseInvalidType = 45049,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45050_CustomMsgUseInvalidType = 45050,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45051_TemplateMsgUseInvalidLink = 45051,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45052_MasssendMsgUseInvalidType = 45052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45053_ExceedConsumeVerifyCodeSize = 45053,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45054_BelowConsumeVerifyCodeSize = 45054,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45055_TheCodeIsNotInConsumeVerifyCodeCharset = 45055,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45056_TooManyTagNowNoNeedToAddNew = 45056,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45057_CanTDeleteTheTagThatHasTooManyFans = 45057,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45058_CanTModifySysTag = 45058,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45059_CanNotTaggingOneUserTooMuch = 45059,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45060_MediaIsAppliedInIvrOrMenuCanNotBeDeleted = 45060,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45061_MaybeTheUpdateFrequencyIsTooOftenPleaseTryAgain = 45061,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45062_HasAgreementAdPleaseUseMpWeixinQqCom = 45062,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45063_AccesstokenIsNotXiaochengxu = 45063,
        ///<summary>
        ///创建菜单包含未关联的小程序
        ///</summary>
        [Description("创建菜单包含未关联的小程序")]
        _45064_NoPermissionToUseWeappInMenu = 45064,
        ///<summary>
        ///相同 clientmsgid 已存在群发记录，返回数据中带有已存在的群发任务的 msgid
        ///</summary>
        [Description("相同 clietmsgid 已存在群发记录，返回数据中带有已存在的群发任务的 msgid")]
        _45065_ClientmsgidExist = 45065,
        ///<summary>
        ///相同 clientmsgid 重试速度过快，请间隔1分钟重试
        ///</summary>
        [Description("相同 clietmsgid 重试速度过快，请间隔1分钟重试")]
        _45066_SameClientmsgidRetryTooFast = 45066,
        ///<summary>
        ///clientmsgid 长度超过限制
        ///</summary>
        [Description("clietmsgid 长度超过限制")]
        _45067_ClientmsgidSizeOutOfLimit = 45067,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45068_FileSizeOutOfLimit = 45068,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45069_ProductListSizeOutOfLimit = 45069,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45070_TheBusinessAccountHaveBeenCreated = 45070,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45071_BusinessAccountNotFound = 45071,
        ///<summary>
        ///command字段取值不对
        ///</summary>
        [Description("commad字段取值不对")]
        _45072_InvalidCommand = 45072,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45073_NotInnerVipForSnsInWhiteList = 45073,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45074_MaterialListSizeOutOfLimitYouShouldDeleteTheUselessMaterial = 45074,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45075_InvalidKeywordId = 45075,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45076_InvalidCount = 45076,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45077_NumberOfBusinessAccountReachLimit = 45077,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45078_NicknameIsIllegal = 45078,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45079_NicknameIsForbiddenMatchedForbiddenKeyword = 45079,
        ///<summary>
        ///下发输入状态，需要之前30秒内跟用户有过消息交互
        ///</summary>
        [Description("下发输入状态，需要之前30秒内跟用户有过消息交互")]
        _45080_NeedSendingMessageToUserOrRecvingMessageFromUserInTheLast30SecondsBeforeTyping = 45080,
        ///<summary>
        ///已经在输入状态，不可重复下发
        ///</summary>
        [Description("已经在输入状态，不可重复下发")]
        _45081_YouAreAlreadyTyping = 45081,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45082_NeedIcpLicenseForTheUrlDomain = 45082,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45083_TheSpeedOutOfRange = 45083,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45084_NoSpeedMessage = 45084,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45085_SpeedServerErr = 45085,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45086_InvalidAttrbuteDataMiniprogramAppid = 45086,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45087_CustomerServiceMessageFromThisAccountHaveBeenBlocked = 45087,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45088_ActionSizeOutOfLimit = 45088,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45089_Expired = 45089,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45090_InvalidGroupMsgTicket = 45090,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45091_AccountNameIsIllegal = 45091,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45092_NoVoiceData = 45092,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45093_NoQuotaToSendMsg = 45093,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45094_NotAllowToSendCustomMessageWhenUserEnterSessionForPunishment = 45094,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45095_NotAllowToModifyStockForTheAdvertisementBatch = 45095,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45096_InvalidQrcode = 45096,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45097_InvalidQrcodePrefix = 45097,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45098_MsgmenuListSizeIsOutOfLimit = 45098,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45099_MsgmenuItemContentSizeIsOutOfLimit = 45099,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45100_InvalidSizeOfKeywordIdList = 45100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45101_HitUploadLimit = 45101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45102_ThisApiHaveBeenBlockedTemporarily = 45102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45103_ThisAPIHasBeenUnsupported = 45103,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45104_ReachMaxDomainQuotaLimit = 45104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45154_TheConsumeVerifyCodeNotFound = 45154,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45155_TheConsumeVerifyCodeIsExisted = 45155,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45156_TheConsumeVerifyCodeSLengthNotInvalid = 45156,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45157_InvalidTagName = 45157,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45158_TagNameTooLong = 45158,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45159_InvalidTagId = 45159,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45160_InvalidCategoryToCreateCard = 45160,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45161_ThisVideoIdMustBeGeneratedByCallingUploadApi = 45161,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45162_InvalidType = 45162,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45163_InvalidSortMethod = 45163,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45164_InvalidOffset = 45164,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45165_InvalidLimit = 45165,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45166_InvalidContent = 45166,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45167_InvalidVoipCallKey = 45167,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45168_KeywordInBlacklist = 45168,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _45501_PartOrWholeOfTheRequestsFromTheVeryAppIsTemporaryBlockedBySupervisor = 45501,
        ///<summary>
        ///不存在媒体数据，media_id 不存在
        ///</summary>
        [Description("不存在媒体数据，media_id 不存在")]
        _46001_MediaDataNoExist = 46001,
        ///<summary>
        ///不存在的菜单版本
        ///</summary>
        [Description("不存在的菜单版本")]
        _46002_MenuVersionNoExist = 46002,
        ///<summary>
        ///不存在的菜单数据
        ///</summary>
        [Description("不存在的菜单数据")]
        _46003_MenuNoExist = 46003,
        ///<summary>
        ///不存在的用户
        ///</summary>
        [Description("不存在的用户")]
        _46004_UserNoExist = 46004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46005_PoiNoExist = 46005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46006_VoipFileNotExist = 46006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46007_FileBeingTranscodedPleaseTryLater = 46007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46008_ResultIdNotExist = 46008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46009_ThereIsNoUserData = 46009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _46101_ThisApiHaveBeenNotSupportedSince20200111000000PleaseUseNewApiSubscribeMessage = 46101,
        ///<summary>
        ///解析 JSON/XML 内容错误
        ///</summary>
        [Description("解析 JSON/XML 内容错误")]
        _47001_DataFormatError = 47001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _47002_DataFormatErrorDoNOTUseJsonUnicodeEncodeUxxxxUxxxxPleaseUseUtf8EncodedText = 47002,
        ///<summary>
        ///模板参数不准确，可能为空或者不满足规则，errmsg会提示具体是哪个字段出错
        ///</summary>
        [Description("模板参数不准确，可能为空或者不满足规则，errmsg会提示具体是哪个字段出错")]
        _47003_ArgumentInvalid = 47003,
        ///<summary>
        ///每次提交的页面数超过1000（备注：每次提交页面数应小于或等于1000）
        ///</summary>
        [Description("每次提交的页面数超过1000（备注：每次提交页面数应小于或等于1000）")]
        _47004_SubmitPagesCountMoreThanEachQuota = 47004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _47005_TabbarNoExist = 47005,
        ///<summary>
        ///当天提交页面数达到了配额上限，请明天再试
        ///</summary>
        [Description("当天提交页面数达到了配额上限，请明天再试")]
        _47006_SubmitPagesCountReachDailyLimitPleaseTryTomorrow = 47006,
        ///<summary>
        ///搜索结果总数超过了1000条
        ///</summary>
        [Description("搜索结果总数超过了1000条")]
        _47101_SearchResultsCountMoreThanLimit = 47101,
        ///<summary>
        ///next_page_info参数错误
        ///</summary>
        [Description("ext_page_ifo参数错误")]
        _47102_NextPageInfoError = 47102,
        ///<summary>
        ///参数 activity_id 错误
        ///</summary>
        [Description("参数 activity_id 错误")]
        _47501_ActivityIdError = 47501,
        ///<summary>
        ///参数 target_state 错误
        ///</summary>
        [Description("参数 target_state 错误")]
        _47502_TargetStateError = 47502,
        ///<summary>
        ///参数 version_type 错误
        ///</summary>
        [Description("参数 versio_type 错误")]
        _47503_VersionTypeError = 47503,
        ///<summary>
        ///activity_id
        ///</summary>
        [Description("activity_id")]
        _47504_ActivityIdExpiredTime = 47504,
        ///<summary>
        ///api 功能未授权，请确认公众号已获得该接口，可以在公众平台官网 - 开发者中心页中查看接口权限
        ///</summary>
        [Description("api 功能未授权，请确认公众号已获得该接口，可以在公众平台官网 - 开发者中心页中查看接口权限")]
        _48001_ApiUnauthorized = 48001,
        ///<summary>
        ///粉丝拒收消息（粉丝在公众号选项中，关闭了 “ 接收消息 ” ）
        ///</summary>
        [Description("粉丝拒收消息（粉丝在公众号选项中，关闭了 “ 接收消息 ” ）")]
        _48002_UserBlockReceiveMessage = 48002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48003_UserNotAgreeMassSendProtocol = 48003,
        ///<summary>
        ///api 接口被封禁，请登录 mp.weixin.qq.com 查看详情
        ///</summary>
        [Description("api 接口被封禁，请登录 mp.weixi.qq.com 查看详情")]
        _48004_ApiForbiddenForIrregularitiesViewDetailOnMpWeixinQqCom = 48004,
        ///<summary>
        ///api 禁止删除被自动回复和自定义菜单引用的素材
        ///</summary>
        [Description("api 禁止删除被自动回复和自定义菜单引用的素材")]
        _48005_ForbidToDeleteMaterialUsedByAutoReplyOrMenu = 48005,
        ///<summary>
        ///api 禁止清零调用次数，因为清零次数达到上限
        ///</summary>
        [Description("api 禁止清零调用次数，因为清零次数达到上限")]
        _48006_ForbidToClearQuotaBecauseOfReachingTheLimit = 48006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48007_ForbidToUseOtherSVoipCallKey = 48007,
        ///<summary>
        ///没有该类型消息的发送权限
        ///</summary>
        [Description("没有该类型消息的发送权限")]
        _48008_NoPermissionForThisMsgtype = 48008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48009_ThisApiIsExpired = 48009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48010_ForbidToModifyTheMaterialPleaseSeeMoreInformationOnMpWeixinQqCom = 48010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48011_DisabledTemplateId = 48011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _48012_InvalidToken = 48012,
        ///<summary>
        ///该视频非新接口上传，不能用于视频消息群发
        ///</summary>
        [Description("该视频非新接口上传，不能用于视频消息群发")]
        _48013_该视频非新接口上传不能用于视频消息群发 = 48013,
        ///<summary>
        ///该视频审核状态异常，请检查后重试
        ///</summary>
        [Description("该视频审核状态异常，请检查后重试")]
        _48014_该视频审核状态异常请检查后重试 = 48014,
        ///<summary>
        ///该账号无留言功能权限
        ///</summary>
        [Description("该账号无留言功能权限")]
        _48015_该账号无留言功能权限 = 48015,
        ///<summary>
        ///该账号不满足智能配置"观看更多"视频条件
        ///</summary>
        [Description("该账号不满足智能配置观看更多视频条件")]
        _48016_该账号不满足智能配置观看更多视频条件 = 48016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49001_NotSameAppidWithAppidOfAccessToken = 49001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49002_EmptyOpenidOrTransid = 49002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49003_NotMatchOpenidWithAppid = 49003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49004_NotMatchSignature = 49004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49005_NotExistedTransid = 49005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49006_MissingArgTwoDimCode = 49006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49007_InvalidTwoDimCode = 49007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49008_InvalidQrcode = 49008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49009_MissingArgQrcode = 49009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49010_InvalidPartnerId = 49010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49300_NotExistedFeedbackid = 49300,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49301_FeedbackExist = 49301,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _49302_FeedbackStatusAlreadyChanged = 49302,
        ///<summary>
        ///用户未授权该 api
        ///</summary>
        [Description("用户未授权该 api")]
        _50001_ApiUnauthorizedOrUserUnauthorized = 50001,
        ///<summary>
        ///用户受限，可能是违规后接口被封禁
        ///</summary>
        [Description("用户受限，可能是违规后接口被封禁")]
        _50002_UserLimited = 50002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _50003_UserUnexpectedMaybeNotInWhiteList = 50003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _50004_UserNotAllowToUseAccesstokenMaybeForPunishment = 50004,
        ///<summary>
        ///用户未关注公众号
        ///</summary>
        [Description("用户未关注公众号")]
        _50005_UserIsUnsubscribed = 50005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _50006_UserHasSwitchedOffFriendsAuthorization = 50006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51000_EnterpriseFatherAccountNotExist = 51000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51001_EnterpriseChildAccountNotBelongToTheFather = 51001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51002_EnterpriseVerifyMessageNotCorrect = 51002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51003_InvalidEnterpriseChildListSize = 51003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51004_NotAEnterpriseFatherAccount = 51004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51005_NotAEnterpriseChildAccount = 51005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51006_InvalidNickName = 51006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51007_NotAEnterpriseAccount = 51007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51008_InvalidEmail = 51008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51009_InvalidPwd = 51009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51010_RepeatedEmail = 51010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51011_AccessDeny = 51011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51012_NeedVerifyCode = 51012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51013_WrongVerifyCode = 51013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51014_NeedModifyPwd = 51014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51015_UserNotExist = 51015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51020_TvInfoNotExist = 51020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51021_StampCrossed = 51021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51022_InvalidStampRange = 51022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51023_StampNotMatchDate = 51023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51024_EmptyProgramName = 51024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51025_EmptyActionUrl = 51025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51026_ProgramNameSizeOutOfLimit = 51026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51027_ActionUrlSizeOutOfLimit = 51027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51028_InvalidProgramName = 51028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51029_InvalidActionUrl = 51029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51030_InvalidActionId = 51030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51031_InvalidActionOffset = 51031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51032_EmptyActionTitle = 51032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51033_ActionTitleSizeOutOfLimit = 51033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51034_EmptyActionIconUrl = 51034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _51035_ActionIconUrlOutOfLimit = 51035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52000_PicIsNotFromCdn = 52000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52001_WechatPriceIsNotLessThanOriginPrice = 52001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52002_CategorySkuIsWrong = 52002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52003_ProductIdNotExisted = 52003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52004_CategoryIdIsNotExistOrDoesnTHasSubCategory = 52004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52005_QuantityIsZero = 52005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52006_AreaCodeIsInvalid = 52006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52007_ExpressTemplateParamIsError = 52007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52008_ExpressTemplateIdIsNotExisted = 52008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52009_GroupNameIsEmpty = 52009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52010_GroupIdIsNotExisted = 52010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52011_ModActionIsInvalid = 52011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52012_ShelfComponentsCountIsGreaterThan20 = 52012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52013_ShelfComponentIsEmpty = 52013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52014_ShelfIdIsNotExisted = 52014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52015_OrderIdIsNotExisted = 52015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52016_OrderFilterParamIsInvalid = 52016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52017_OrderExpressParamIsInvalid = 52017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52018_OrderDeliveryParamIsInvalid = 52018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _52019_BrandNameEmpty = 52019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53000_PrincipalLimitExceed = 53000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53001_PrincipalInBlackList = 53001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53002_MobileLimitExceed = 53002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53003_IdcardLimitExceed = 53003,
        ///<summary>
        ///名称格式不合法
        ///</summary>
        [Description("名称格式不合法")]
        _53010_NicknameInvalid = 53010,
        ///<summary>
        ///名称检测命中频率限制
        ///</summary>
        [Description("名称检测命中频率限制")]
        _53011_CheckNicknameTooFrequently = 53011,
        ///<summary>
        ///禁止使用该名称
        ///</summary>
        [Description("禁止使用该名称")]
        _53012_NicknameBan = 53012,
        ///<summary>
        ///公众号：名称与已有公众号名称重复;小程序：该名称与已有小程序名称重复
        ///</summary>
        [Description("公众号：名称与已有公众号名称重复;小程序：该名称与已有小程序名称重复")]
        _53013_NicknameHasBeenOccupied = 53013,
        ///<summary>
        ///公众号：公众号已有{名称  A+}时，需与该帐号相同主体才可申请{名称 A};小程序：小程序已有{名称 A+}时，需与该帐号相同主体才可申请{名称 A}
        ///</summary>
        [Description("公众号：公众号已有{名称  A+}时，需与该帐号相同主体才可申请{名称 A};小程序：小程序已有{名称 A+}时，需与该帐号相同主体才可申请{名称 A}")]
        _53014_公众号公众号已有名称A时需与该帐号相同主体才可申请名称A小程序小程序已有名称A时需与该帐号相同主体才可申请名称A = 53014,
        ///<summary>
        ///公众号：该名称与已有小程序名称重复，需与该小程序帐号相同主体才可申请;小程序：该名称与已有公众号名称重复，需与该公众号帐号相同主体才可申请
        ///</summary>
        [Description("公众号：该名称与已有小程序名称重复，需与该小程序帐号相同主体才可申请;小程序：该名称与已有公众号名称重复，需与该公众号帐号相同主体才可申请")]
        _53015_公众号该名称与已有小程序名称重复需与该小程序帐号相同主体才可申请小程序该名称与已有公众号名称重复需与该公众号帐号相同主体才可申请 = 53015,
        ///<summary>
        ///公众号：该名称与已有多个小程序名称重复，暂不支持申请;小程序：该名称与已有多个公众号名称重复，暂不支持申请
        ///</summary>
        [Description("公众号：该名称与已有多个小程序名称重复，暂不支持申请;小程序：该名称与已有多个公众号名称重复，暂不支持申请")]
        _53016_公众号该名称与已有多个小程序名称重复暂不支持申请小程序该名称与已有多个公众号名称重复暂不支持申请 = 53016,
        ///<summary>
        ///公众号：小程序已有{名称  A+}时，需与该帐号相同主体才可申请{名称 A};小程序：公众号已有{名称 A+}时，需与该帐号相同主体才可申请{名称 A}
        ///</summary>
        [Description("公众号：小程序已有{名称  A+}时，需与该帐号相同主体才可申请{名称 A};小程序：公众号已有{名称 A+}时，需与该帐号相同主体才可申请{名称 A}")]
        _53017_公众号小程序已有名称A时需与该帐号相同主体才可申请名称A小程序公众号已有名称A时需与该帐号相同主体才可申请名称A = 53017,
        ///<summary>
        ///名称命中微信号
        ///</summary>
        [Description("名称命中微信号")]
        _53018_NicknameHitAlias = 53018,
        ///<summary>
        ///名称在保护期内
        ///</summary>
        [Description("名称在保护期内")]
        _53019_NicknameProtectedByInfringement = 53019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53100_OrderNotFound = 53100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53101_OrderAlreadyPaid = 53101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53102_AlreadyHasCheckingOrderCanNotApply = 53102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53103_OrderCanNotDoRefill = 53103,
        ///<summary>
        ///本月功能介绍修改次数已用完
        ///</summary>
        [Description("本月功能介绍修改次数已用完")]
        _53200_ModifySignatureQuotaLimitExceed = 53200,
        ///<summary>
        ///功能介绍内容命中黑名单关键字
        ///</summary>
        [Description("功能介绍内容命中黑名单关键字")]
        _53201_SignatureInBlackListCanNotUse = 53201,
        ///<summary>
        ///本月头像修改次数已用完
        ///</summary>
        [Description("本月头像修改次数已用完")]
        _53202_ModifyAvatarQuotaLimitExceed = 53202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53203_CanTBeModifiedForTheTimeBeing = 53203,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _53204_SignatureInvalid = 53204,
        ///<summary>
        ///超出每月次数限制
        ///</summary>
        [Description("超出每月次数限制")]
        _53300_超出每月次数限制 = 53300,
        ///<summary>
        ///超出可配置类目总数限制
        ///</summary>
        [Description("超出可配置类目总数限制")]
        _53301_超出可配置类目总数限制 = 53301,
        ///<summary>
        ///当前账号主体类型不允许设置此种类目
        ///</summary>
        [Description("当前账号主体类型不允许设置此种类目")]
        _53302_当前账号主体类型不允许设置此种类目 = 53302,
        ///<summary>
        ///提交的参数不合法
        ///</summary>
        [Description("提交的参数不合法")]
        _53303_提交的参数不合法 = 53303,
        ///<summary>
        ///与已有类目重复
        ///</summary>
        [Description("与已有类目重复")]
        _53304_与已有类目重复 = 53304,
        ///<summary>
        ///包含未通过IPC校验的类目
        ///</summary>
        [Description("包含未通过IPC校验的类目")]
        _53305_包含未通过IPC校验的类目 = 53305,
        ///<summary>
        ///修改类目只允许修改类目资质，不允许修改类目ID
        ///</summary>
        [Description("修改类目只允许修改类目资质，不允许修改类目ID")]
        _53306_修改类目只允许修改类目资质不允许修改类目ID = 53306,
        ///<summary>
        ///只有审核失败的类目允许修改
        ///</summary>
        [Description("只有审核失败的类目允许修改")]
        _53307_只有审核失败的类目允许修改 = 53307,
        ///<summary>
        ///审核中的类目不允许删除
        ///</summary>
        [Description("审核中的类目不允许删除")]
        _53308_审核中的类目不允许删除 = 53308,
        ///<summary>
        ///社交红包不允许删除
        ///</summary>
        [Description("社交红包不允许删除")]
        _53309_社交红包不允许删除 = 53309,
        ///<summary>
        ///类目超过上限，但是可以添加apply_reason参数申请更多类目
        ///</summary>
        [Description("类目超过上限，但是可以添加apply_reaso参数申请更多类目")]
        _53310_类目超过上限但是可以添加applyReason参数申请更多类目 = 53310,
        ///<summary>
        ///需要提交资料信息
        ///</summary>
        [Description("需要提交资料信息")]
        _53311_需要提交资料信息 = 53311,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _60005_EmptyJsapiName = 60005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _60006_UserCancelTheAuth = 60006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61000_InvalidComponentType = 61000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61001_ComponentTypeAndComponentAppidIsNotMatch = 61001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61002_TheThirdAppidIsNotOpenKF = 61002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61003_ComponentIsNotAuthorizedByThisAccount = 61003,
        ///<summary>
        ///api 功能未授权，请确认公众号/小程序已获得该接口，可以在公众平台官网 - 开发者中心页中查看接口权限
        ///</summary>
        [Description("api 功能未授权，请确认公众号/小程序已获得该接口，可以在公众平台官网 - 开发者中心页中查看接口权限")]
        _61004_AccessClientipIsNotRegistered = 61004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61005_ComponentTicketIsExpired = 61005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61006_ComponentTicketIsInvalid = 61006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61007_ApiIsUnauthorizedToComponent = 61007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61008_ComponentReqKeyIsDuplicated = 61008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61009_CodeIsInvalid = 61009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61010_CodeIsExpired = 61010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61011_InvalidComponent = 61011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61012_InvalidOptionName = 61012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61013_InvalidOptionValue = 61013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61014_MustUseComponentTokenForComponentApi = 61014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61015_MustUseBizAccountTokenForNotComponentApi = 61015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61016_FunctionCategoryOfAPINeedBeConfirmedByComponent = 61016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61017_FunctionCategoryIsNotAuthorized = 61017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61018_AlreadyConfirm = 61018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61019_NotNeedConfirm = 61019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61020_ErrParameter = 61020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61021_CanTConfirm = 61021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61022_CanTResubmit = 61022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61023_RefreshTokenIsInvalid = 61023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61024_MustUseApiApiComponentTokenToGetTokenForComponentAcct = 61024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61025_ReadOnlyOption = 61025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61026_RegisterAccessDeny = 61026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61027_RegisterLimitExceed = 61027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61028_ComponentIsUnpublished = 61028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61029_ComponentNeedRepublishWithBaseCategory = 61029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61030_ComponentCancelAuthorizationNotAllowed = 61030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61051_InvalidRealnameType = 61051,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61052_NeedToBeCertified = 61052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61053_RealnameExceedLimits = 61053,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61054_RealnameInBlackList = 61054,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61055_ExceedQuotaPerMonth = 61055,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61056_CopyWxVerifyIsRequiredOption = 61056,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61058_InvalidTicket = 61058,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61061_OverseasAccessDeny = 61061,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61063_AdminExceedLimits = 61063,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61064_AdminInBlackList = 61064,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61065_IdcardExceedLimits = 61065,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61066_IdcardInBlackList = 61066,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61067_MobileExceedLimits = 61067,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61068_MobileInBlackList = 61068,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61069_InvalidAdmin = 61069,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61070_NameIdcardWechatNameNotInAccordance = 61070,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61100_InvalidUrl = 61100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61101_InvalidOpenid = 61101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61102_ShareRelationNotExisted = 61102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61200_ProductWordingNotSet = 61200,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61300_InvalidBaseInfo = 61300,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61301_InvalidDetailInfo = 61301,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61302_InvalidActionInfo = 61302,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61303_BrandInfoNotExist = 61303,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61304_InvalidProductId = 61304,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61305_InvalidKeyInfo = 61305,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61306_InvalidAppid = 61306,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61307_InvalidCardId = 61307,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61308_BaseInfoNotExist = 61308,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61309_DetailInfoNotExist = 61309,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61310_ActionInfoNotExist = 61310,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61311_InvalidMediaInfo = 61311,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61312_InvalidBufferSize = 61312,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61313_InvalidBuffer = 61313,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61314_InvalidQrcodeExtinfo = 61314,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61315_InvalidLocalExtInfo = 61315,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61316_KeyConflict = 61316,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61317_TicketInvalid = 61317,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61318_VerifyNotPass = 61318,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61319_CategoryInvalid = 61319,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61320_MerchantInfoNotExist = 61320,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61321_CateIdIsALeafNode = 61321,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61322_CategoryIdNoPermision = 61322,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61323_BarcodeNoPermision = 61323,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61324_ExceedMaxActionNum = 61324,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61325_BrandinfoInvalidStoreMgrType = 61325,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61326_AntiSpamBlocked = 61326,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61327_CommentReachLimit = 61327,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61328_CommentDataIsNotTheNewest = 61328,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61329_CommentHitBanWord = 61329,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61330_ImageAlreadyAdd = 61330,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61331_ImageNeverAdd = 61331,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61332_WarningImageQuanlityTooLow = 61332,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61333_WarningImageSimilityTooHigh = 61333,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61334_ProductNotExists = 61334,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61335_KeyApplyFail = 61335,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61336_CheckStatusFail = 61336,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61337_ProductAlreadyExists = 61337,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61338_ForbidDelete = 61338,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61339_FirmcodeClaimed = 61339,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61340_CheckFirmInfoFail = 61340,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61341_TooManyWhiteListUin = 61341,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61342_KeystandardNotMatch = 61342,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61343_KeystandardError = 61343,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61344_IdMapNotExists = 61344,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61345_InvalidActionCode = 61345,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61346_InvalidActioninfoStore = 61346,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61347_InvalidActioninfoMedia = 61347,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61348_InvalidActioninfoText = 61348,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61350_InvalidInputData = 61350,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61351_InputDataExceedMaxSize = 61351,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61400_KfAccountError = 61400,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61401_KfSystemAlredyTransfer = 61401,
        ///<summary>
        ///系统错误 (system error)
        ///</summary>
        [Description("系统错误 (system error)")]
        _61450_系统错误SystemError = 61450,
        ///<summary>
        ///参数错误 (invalid parameter)
        ///</summary>
        [Description("参数错误 (ivalid parameter)")]
        _61451_参数错误InvalidParameter = 61451,
        ///<summary>
        ///无效客服账号 (invalid kf_account)
        ///</summary>
        [Description("无效客服账号 (ivalid kf_accout)")]
        _61452_无效客服账号InvalidKfAccount = 61452,
        ///<summary>
        ///客服帐号已存在 (kf_account exsited)
        ///</summary>
        [Description("客服帐号已存在 (kf_accout exsited)")]
        _61453_客服帐号已存在KfAccountExsited = 61453,
        ///<summary>
        ///客服帐号名长度超过限制 ( 仅允许 10 个英文字符，不包括 @ 及 @ 后的公众号的微信号 )(invalid  kf_acount  length)
        ///</summary>
        [Description("客服帐号名长度超过限制 ( 仅允许 10 个英文字符，不包括 @ 及 @ 后的公众号的微信号 )(ivalid  kf_acout  legth)")]
        _61454_客服帐号名长度超过限制仅允许10个英文字符不包括及后的公众号的微信号InvalidKfAcountLength = 61454,
        ///<summary>
        ///客服帐号名包含非法字符 ( 仅允许英文 + 数字 )(illegal character in   kf_account)
        ///</summary>
        [Description("客服帐号名包含非法字符 ( 仅允许英文 + 数字 )(illegal character i   kf_accout)")]
        _61455_客服帐号名包含非法字符仅允许英文数字IllegalCharacterInKfAccount = 61455,
        ///<summary>
        ///客服帐号个数超过限制 (10 个客服账号 )(kf_account count exceeded)
        ///</summary>
        [Description("客服帐号个数超过限制 (10 个客服账号 )(kf_accout cout exceeded)")]
        _61456_客服帐号个数超过限制10个客服账号KfAccountCountExceeded = 61456,
        ///<summary>
        ///无效头像文件类型 (invalid  file type)
        ///</summary>
        [Description("无效头像文件类型 (ivalid  file type)")]
        _61457_无效头像文件类型InvalidFileType = 61457,
        ///<summary>
        ///日期格式错误
        ///</summary>
        [Description("日期格式错误")]
        _61500_DateFormatError = 61500,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61501_DateRangeError = 61501,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61502_ThisIsGameMiniprogramDataApiIsNotSupported = 61502,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _61503_DataNotReadyPleaseTryLater = 61503,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _62001_TryingToAccessOtherSApp = 62001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _62002_AppNameAlreadyExists = 62002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _62003_PleaseProvideAtLeastOnePlatform = 62003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _62004_InvalidAppName = 62004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _62005_InvalidAppId = 62005,
        ///<summary>
        ///部分参数为空
        ///</summary>
        [Description("部分参数为空")]
        _63001_SomeArgumentsIsEmpty = 63001,
        ///<summary>
        ///无效的签名
        ///</summary>
        [Description("无效的签名")]
        _63002_InvalidSignature = 63002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63003_InvalidSignatureMethod = 63003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63004_NoAuthroize = 63004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63149_GenTicketFail = 63149,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63152_SetTicketFail = 63152,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63153_ShortidDecodeFail = 63153,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63154_InvalidStatus = 63154,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63155_InvalidColor = 63155,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63156_InvalidTag = 63156,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63157_InvalidRecommend = 63157,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63158_BranditemOutOfLimits = 63158,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63159_RetailPriceEmpty = 63159,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63160_PriceinfoInvalid = 63160,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63161_AntifakeModuleNumLimit = 63161,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63162_AntifakeNativeTypeErr = 63162,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63163_AntifakeLinkNotExists = 63163,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63164_ModuleTypeNotExist = 63164,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63165_ModuleInfoNotExist = 63165,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63166_ItemIsBedingVerified = 63166,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63167_ItemNotPublished = 63167,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63168_VerifyNotPass = 63168,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63169_AlreadyPublished = 63169,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63170_OnlyBannerOrMedia = 63170,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63171_CardNumLimit = 63171,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63172_UserNumLimit = 63172,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63173_TextNumLimit = 63173,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63174_LinkCardUserSumLimit = 63174,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63175_DetailInfoError = 63175,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63176_NotThisType = 63176,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63177_SrcOrSecretkeyOrVersionOrExpiredTimeIsWrong = 63177,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63178_AppidWrong = 63178,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63179_OpenidNumLimit = 63179,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63180_ThisAppMsgNotFound = 63180,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63181_GetHistoryAppMsgEnd = 63181,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _63182_OpenidListEmpty = 63182,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65001_UnknownDeeplinkType = 65001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65002_DeeplinkUnauthorized = 65002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65003_BadDeeplink = 65003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65004_DeeplinksOfTheVeryTypeAreSupposedToHaveShortLife = 65004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65104_InvalidCategories = 65104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65105_InvalidPhotoUrl = 65105,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65106_PoiAuditStateMustBeApproved = 65106,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65107_PoiNotAllowedModifyNow = 65107,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65109_InvalidBusinessName = 65109,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65110_InvalidAddress = 65110,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65111_InvalidTelephone = 65111,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65112_InvalidCity = 65112,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65113_InvalidProvince = 65113,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65114_PhotoListEmpty = 65114,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65115_PoiIdIsNotExist = 65115,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65116_PoiHasBeenDeleted = 65116,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65117_CannotDeletePoi = 65117,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65118_StoreStatusIsInvalid = 65118,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65119_LackOfQualificationForRelevantPrincipals = 65119,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65120_CategoryInfoIsNotFound = 65120,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65201_RoomNameIsEmptyPleaseCheckYourInput = 65201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65202_UserIdIsEmptyPleaseCheckYourInput = 65202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65203_InvalidCheckTicket = 65203,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65204_InvalidCheckTicketOptCode = 65204,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65205_CheckTicketOutOfTime = 65205,
        ///<summary>
        ///不存在此 menuid 对应的个性化菜单
        ///</summary>
        [Description("不存在此 meuid 对应的个性化菜单")]
        _65301_ThisMenuIsNotConditionalmenu = 65301,
        ///<summary>
        ///没有相应的用户
        ///</summary>
        [Description("没有相应的用户")]
        _65302_NoSuchUser = 65302,
        ///<summary>
        ///没有默认菜单，不能创建个性化菜单
        ///</summary>
        [Description("没有默认菜单，不能创建个性化菜单")]
        _65303_ThereIsNoSelfmenuPleaseCreateSelfmenuFirst = 65303,
        ///<summary>
        ///MatchRule 信息为空
        ///</summary>
        [Description("MatchRule 信息为空")]
        _65304_MatchRuleEmpty = 65304,
        ///<summary>
        ///个性化菜单数量受限
        ///</summary>
        [Description("个性化菜单数量受限")]
        _65305_MenuCountLimit = 65305,
        ///<summary>
        ///不支持个性化菜单的帐号
        ///</summary>
        [Description("不支持个性化菜单的帐号")]
        _65306_ConditionalMenuNotSupport = 65306,
        ///<summary>
        ///个性化菜单信息为空
        ///</summary>
        [Description("个性化菜单信息为空")]
        _65307_ConditionalMenuIsEmpty = 65307,
        ///<summary>
        ///包含没有响应类型的 button
        ///</summary>
        [Description("包含没有响应类型的 butto")]
        _65308_ExistEmptyButtonAct = 65308,
        ///<summary>
        ///个性化菜单开关处于关闭状态
        ///</summary>
        [Description("个性化菜单开关处于关闭状态")]
        _65309_ConditionalMenuSwitchIsClosed = 65309,
        ///<summary>
        ///填写了省份或城市信息，国家信息不能为空
        ///</summary>
        [Description("填写了省份或城市信息，国家信息不能为空")]
        _65310_RegionInfoCountryIsEmpty = 65310,
        ///<summary>
        ///填写了城市信息，省份信息不能为空
        ///</summary>
        [Description("填写了城市信息，省份信息不能为空")]
        _65311_RegionInfoProvinceIsEmpty = 65311,
        ///<summary>
        ///不合法的国家信息
        ///</summary>
        [Description("不合法的国家信息")]
        _65312_InvalidCountryInfo = 65312,
        ///<summary>
        ///不合法的省份信息
        ///</summary>
        [Description("不合法的省份信息")]
        _65313_InvalidProvinceInfo = 65313,
        ///<summary>
        ///不合法的城市信息
        ///</summary>
        [Description("不合法的城市信息")]
        _65314_InvalidCityInfo = 65314,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65315_NotFans = 65315,
        ///<summary>
        ///该公众号的菜单设置了过多的域名外跳（最多跳转到 3 个域名的链接）
        ///</summary>
        [Description("该公众号的菜单设置了过多的域名外跳（最多跳转到 3 个域名的链接）")]
        _65316_DomainCountReachLimit = 65316,
        ///<summary>
        ///不合法的 URL
        ///</summary>
        [Description("不合法的 URL")]
        _65317_ContainInvalidUrl = 65317,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65318_MustUseUtf8Charset = 65318,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65319_NotAllowToCreateMenu = 65319,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65400_PleaseEnableNewCustomServiceOrWaitForAWhileIfYouHaveEnabled = 65400,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65401_InvalidCustomServiceAccount = 65401,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65402_TheCustomServiceAccountNeedToBindAWechatUser = 65402,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65403_IllegalNickname = 65403,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65404_IllegalCustomServiceAccount = 65404,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65405_CustomServiceAccountNumberReachLimit = 65405,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65406_CustomServiceAccountExists = 65406,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65407_TheWechatUserHaveBeenOneOfYourWorkers = 65407,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65408_YouHaveAlreadyInvitedTheWechatUser = 65408,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65409_WechatAccountInvalid = 65409,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65410_TooManyCustomServiceAccountsBoundByTheWorker = 65410,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65411_AEffectiveInvitationToBindTheCustomServiceAccountExists = 65411,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65412_TheCustomServiceAccountHaveBeenBoundByAWechatUser = 65412,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65413_NoEffectiveSessionForTheCustomer = 65413,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65414_AnotherWorkerIsServingTheCustomer = 65414,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65415_TheWorkerIsNotOnline = 65415,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65416_ParamInvalidPleaseCheck = 65416,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65417_ItIsTooLongFromTheStarttimeToEndtime = 65417,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _65450_HomepageNotExists = 65450,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68002_InvalidStoreType = 68002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68003_InvalidStoreName = 68003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68004_InvalidStoreWxaPath = 68004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68005_MissStoreWxaPath = 68005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68006_InvalidKefuType = 68006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68007_InvalidKefuWxaPath = 68007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68008_InvalidKefuPhoneNumber = 68008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68009_InvalidSubMchId = 68009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68010_StoreIdHasExist = 68010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68011_MissStoreName = 68011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68012_MissCreateTime = 68012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68013_InvalidStatus = 68013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68014_InvalidReceiverInfo = 68014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68015_InvalidProduct = 68015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68016_InvalidPayType = 68016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68017_InvalidFastMailNo = 68017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68018_InvalidBusiId = 68018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68019_MissProductSku = 68019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68020_InvalidServiceType = 68020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68021_InvalidServiceStatus = 68021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68022_InvalidServiceId = 68022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68023_ServiceIdHasExist = 68023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68024_MissServiceWxaPath = 68024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68025_InvalidProductSku = 68025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68026_InvalidProductSpu = 68026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68027_MissProductSpu = 68027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68028_CanNotFindProductSpuAndSpuInOrderList = 68028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68029_SkuAndSpuDuplicated = 68029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68030_BusiIdHasExist = 68030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68031_UpdateFail = 68031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68032_BusiIdNotExist = 68032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68033_StoreNoExist = 68033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68034_MissProductNumber = 68034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68035_MissWxaOrderDetailPath = 68035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68036_ThereIsNoEnoughProductsToRefund = 68036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68037_InvalidRefundInfo = 68037,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68038_ShippedButNoFastMailInfo = 68038,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68039_InvalidWechatPayNo = 68039,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68040_AllProductHasBeenRefundedTheOrderCanNotBeFinished = 68040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68041_InvalidServiceCreateTimeItMustBiggerThanTheTimeOfOrder = 68041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68042_InvalidTotalCostItMustBeSmallerThanTheSumOfProductAndShippingCost = 68042,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68043_InvalidRole = 68043,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68044_InvalidServiceAvailableArgs = 68044,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68045_InvalidOrderType = 68045,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68046_InvalidOrderDeliverType = 68046,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68500_RequireStoreId = 68500,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _68501_InvalidStoreId = 68501,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71001_InvalidParameterParameterIsZeroOrMissing = 71001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71002_InvalidOrderidMayBeTheOtherParameterNotFitWithOrderid = 71002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71003_CoinNotEnough = 71003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71004_CardIsExpired = 71004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71005_LimitExeCount = 71005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71006_LimitCoinCount1LtCoinCountLt100000 = 71006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71007_OrderFinish = 71007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _71008_OrderTimeOut = 71008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72001_NoMatchCard = 72001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72002_MchidIsNotBindAppid = 72002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72003_InvalidCardTypeNeedMemberCard = 72003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72004_MchidIsOccupiedByTheOtherAppid = 72004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72005_OutOfMchidSizeLimit = 72005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72006_InvaldTitle = 72006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72007_InvalidReduceCostCanNotLessThan100 = 72007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72008_InvalidLeastCostMostLargerThanReduceCost = 72008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72009_InvalidGetLimitCanNotOver50 = 72009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72010_InvalidMchid = 72010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72011_InvalidActivateTicketMaybeThisTicketIsNotBelongThisAppId = 72011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72012_ActivateTicketHasBeenExpired = 72012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72013_UnauthorizedOrderIdOrAuthorizationIsExpired = 72013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72014_TaskCardShareStockCanNotModifyStock = 72014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72015_UnauthorizedCreateInvoice = 72015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72016_UnauthorizedCreateMemberCard = 72016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72017_InvalidInvoiceTitle = 72017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72018_DuplicateOrderIdInvoiceHadInsertedToUser = 72018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72019_LimitMsgOperationCardListSizeMustLt5 = 72019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72020_LimitConsumeInUseLimit = 72020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72021_UnauthorizedCreateGeneralCard = 72021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72022_UserUnexpectedPleaseAddUserToWhiteList = 72022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72023_InvoiceHasBeenLockByOthers = 72023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72024_InvoiceStatusError = 72024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72025_InvoiceTokenError = 72025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72026_NeedSetWxActivateTrue = 72026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72027_InvoiceActionError = 72027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72028_InvoiceNeverSetPayMchInfo = 72028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72029_InvoiceNeverSetAuthField = 72029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72030_InvalidMchid = 72030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72031_InvalidParams = 72031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72032_PayGiftCardRuleExpired = 72032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72033_PayGiftCardRuleStatusErr = 72033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72034_InvlidRuleId = 72034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72035_BizRejectInsert = 72035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72036_InvoiceIsBusyTryAgainPlease = 72036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72037_InvoiceOwnerError = 72037,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72038_InvoiceOrderNeverAuth = 72038,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72039_InvoiceMustBeLockFirst = 72039,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72040_InvoicePdfError = 72040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72041_BillingCodeAndBillingNoInvalid = 72041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72042_BillingCodeAndBillingNoRepeated = 72042,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72043_BillingCodeOrBillingNoSizeError = 72043,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72044_ScanTextOutOfTime = 72044,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72045_CheckCodeIsEmpty = 72045,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72046_PdfUrlIsInvalid = 72046,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72047_PdfBillingCodeOrPdfBillingNoIsError = 72047,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72048_InsertTooManyInvoiceNeedAuthAgain = 72048,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72049_NeverAuth = 72049,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72050_AuthExpiredNeedAuthAgain = 72050,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72051_AppTypeError = 72051,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72052_GetTooManyInvoice = 72052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72053_UserNeverAuth = 72053,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72054_InvoicesIsInsertingWaitAMomentPlease = 72054,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72055_TooManyInvoices = 72055,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72056_OrderIdRepeatedPleaseCheckOrderId = 72056,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72057_TodayInsertLimit = 72057,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72058_CallbackBizError = 72058,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72059_ThisInvoiceIsGivingToOthersWaitAMomentPlease = 72059,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72060_ThisInvoiceHasBeenCancelledCheckTheReimburseStatusPlease = 72060,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72061_ThisInvoiceHasBeenClosedCheckTheReimburseStatusPlease = 72061,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72062_ThisCodeAuthKeyIsLimitedTryOtherCodeAuthKeyPlease = 72062,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72063_BizContactIsEmptySetContactFirstPlease = 72063,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72064_TbcError = 72064,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72065_TbcLogicError = 72065,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72066_TheCardIsSendForAdvertisementNotAllowModifyTimeAndBudget = 72066,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72067_BatchInsertAuthKeyExpired = 72067,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72068_BatchInsertAuthKeyOwner = 72068,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72069_BATCHTASKRUNERROR = 72069,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72070_BIZTITLEKEYOUTTIME = 72070,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72071_DiscernGaoPengError = 72071,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72072_DiscernTypeError = 72072,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72073_FeeError = 72073,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72074_HASAuth = 72074,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72075_HASSEND = 72075,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72076_INVOICESIGN = 72076,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72077_KEYDELETED = 72077,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72078_KEYEXPIRED = 72078,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72079_MOUNTERROR = 72079,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72080_NOFOUND = 72080,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72081_NoPullPdf = 72081,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72082_PDFCHECKERROR = 72082,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72083_PULLPDFFAIL = 72083,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72084_PUSHBIZEMPTY = 72084,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72085_SDKAPPIDERROR = 72085,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72086_SDKBIZERROR = 72086,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72087_SDKURLERROR = 72087,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72088_SearchTitleFail = 72088,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72089_TITLEBUSY = 72089,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72090_TITLENOFOUND = 72090,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72091_TOKENERR = 72091,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72092_USERTITLENOTFOUND = 72092,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _72093_Verify3rdFail = 72093,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73000_SysErrorMakeOutInvoiceFailed = 73000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73001_WxopenidError = 73001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73002_DdhOrderidEmpty = 73002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73003_WxopenidEmpty = 73003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73004_FpqqlshEmpty = 73004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73005_NotACommercial = 73005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73006_KplxEmpty = 73006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73007_NsrmcEmpty = 73007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73008_NsrdzEmpty = 73008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73009_NsrdhEmpty = 73009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73010_GhfmcEmpty = 73010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73011_KprEmpty = 73011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73012_JshjEmpty = 73012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73013_HjjeEmpty = 73013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73014_HjseEmpty = 73014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73015_HylxEmpty = 73015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73016_NsrsbhEmpty = 73016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73100_KaipiaoPlatError = 73100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73101_NsrsbhNotCmp = 73101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73103_InvalidWxaAppidInUrlCellWxaAppidIsNeedToBindBizAppid = 73103,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73104_ReachFrequencyLimit = 73104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73105_KpPlatMakeInvoiceTimeoutPleaseTryAgainWithTheSameFpqqlsh = 73105,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73106_FpqqlshExistWithDifferentDdh = 73106,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73107_FpqqlshIsProcessingPleaseWaitAndQueryLater = 73107,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73108_ThisDdhWithOtherFpqqlshAlreadyExist = 73108,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73109_ThisFpqqlshNotExistInKpplat = 73109,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73200_GetCardDetailByCardIdAndCodeFail = 73200,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73201_GetCloudInvoiceRecordFail = 73201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73202_GetAppinfoFail = 73202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73203_GetInvoiceCategoryOrRuleKvError = 73203,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73204_RequestCardNotExist = 73204,
        ///<summary>
        ///朋友的券玩法升级中，当前暂停创建，请创建其他类型卡券
        ///</summary>
        [Description("朋友的券玩法升级中，当前暂停创建，请创建其他类型卡券")]
        _73205_朋友的券玩法升级中当前暂停创建请创建其他类型卡券 = 73205,
        ///<summary>
        ///朋友的券玩法升级中，当前暂停券点充值，请创建其他类型卡券
        ///</summary>
        [Description("朋友的券玩法升级中，当前暂停券点充值，请创建其他类型卡券")]
        _73206_朋友的券玩法升级中当前暂停券点充值请创建其他类型卡券 = 73206,
        ///<summary>
        ///朋友的券玩法升级中，当前暂停开通券点账户
        ///</summary>
        [Description("朋友的券玩法升级中，当前暂停开通券点账户")]
        _73207_朋友的券玩法升级中当前暂停开通券点账户 = 73207,
        ///<summary>
        ///朋友的券玩法升级中，当前不支持修改库存
        ///</summary>
        [Description("朋友的券玩法升级中，当前不支持修改库存")]
        _73208_朋友的券玩法升级中当前不支持修改库存 = 73208,
        ///<summary>
        ///朋友的券玩法升级中，当前不支持修改有效期
        ///</summary>
        [Description("朋友的券玩法升级中，当前不支持修改有效期")]
        _73209_朋友的券玩法升级中当前不支持修改有效期 = 73209,
        ///<summary>
        ///当前批次不支持修改卡券批次库存
        ///</summary>
        [Description("当前批次不支持修改卡券批次库存")]
        _73210_当前批次不支持修改卡券批次库存 = 73210,
        ///<summary>
        ///不再支持配置网页链接跳转，请选择小程序替代
        ///</summary>
        [Description("不再支持配置网页链接跳转，请选择小程序替代")]
        _73211_不再支持配置网页链接跳转请选择小程序替代 = 73211,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73212_UnauthorizedBackupMember = 73212,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73213_InvalidCodeType = 73213,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _73214_TheUserIsAlreadyAMember = 73214,
        ///<summary>
        ///支付打通券能力已下线，请直接使用微信支付代金券API：https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/marketing/convention/chapter1_1.shtml
        ///</summary>
        [Description("支付打通券能力已下线，请直接使用微信支付代金券API：https://pay.weixi.qq.com/wiki/doc/apiv3/wxpay/marketig/covetio/chapter1_1.shtml")]
        _73215_支付打通券能力已下线请直接使用微信支付代金券APIHttpsPayWeixinQqComWikiDocApiv3WxpayMarketingConventionChapter11Shtml = 73215,
        ///<summary>
        ///不合法的按钮名字，请从中选择一个:使用礼品卡/立即使用/去点外卖
        ///</summary>
        [Description("不合法的按钮名字，请从中选择一个:使用礼品卡/立即使用/去点外卖")]
        _73216_不合法的按钮名字请从中选择一个使用礼品卡立即使用去点外卖 = 73216,
        ///<summary>
        ///礼品卡本身没有设置appname和path，不允许在修改接口设置
        ///</summary>
        [Description("礼品卡本身没有设置appame和path，不允许在修改接口设置")]
        _73217_礼品卡本身没有设置appname和path不允许在修改接口设置 = 73217,
        ///<summary>
        ///未授权使用礼品卡落地页跳转小程序功能
        ///</summary>
        [Description("未授权使用礼品卡落地页跳转小程序功能")]
        _73218_未授权使用礼品卡落地页跳转小程序功能 = 73218,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74000_NotFindThisWxHotelIdInfo = 74000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74001_RequestSomeParamEmpty = 74001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74002_RequestSomeParamError = 74002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74003_RequestSomeParamError = 74003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74004_DatetimeError = 74004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74005_CheckinModeError = 74005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74007_CaridFromError = 74007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74008_ThisHotelRoutecodeNotExist = 74008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74009_ThisHotelRoutecodeInfoErrorContractDeveloper = 74009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74010_MaybeNotSupportReportMode = 74010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74011_PicDeocdeNotOkMaybeItsNotGoodPicdata = 74011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74021_VerifySysErro = 74021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74022_InnerPoliceErro = 74022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74023_UnableToDetectTheFace = 74023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74040_ReportCheckin2LvyeSysErro = 74040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _74041_ReportCheckou2LvyeSysErro = 74041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75001_SomeParamEmtpyPleaseCheck = 75001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75002_ParamIllegalPleaseCheck = 75002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75003_SysErrorKvStoreError = 75003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75004_SysErrorKvstringStoreError = 75004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75005_ProductNotExistPleaseCheckYourProductId = 75005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75006_OrderNotExistPleaseCheckOrderIdAndBuyerAppid = 75006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75007_DoNotAllowThisStatusToChangePleaseCheckThisOrderIdStatusNow = 75007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75008_ProductHasExistPleaseUseNewId = 75008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75009_NotifyOrderStatusFailed = 75009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75010_BuyerBussinessInfoNotExist = 75010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75011_YouHadRegistered = 75011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75012_StoreImageKeyToKvErrorPleaseTryAgain = 75012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75013_GetImageFailPleaseCheckYouImageKey = 75013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75014_ThisKeyIsNotBelongToYou = 75014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75015_ThisKeyIsExpired = 75015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75016_EncryptDecodeKeyFail = 75016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75017_EncryptEncodeKeyFail = 75017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75018_BindBuyerBusinessInfoFailPleaseContactUs = 75018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _75019_ThisKeyIsEmptyUserMayNotUploadFile = 75019,
        ///<summary>
        ///系统错误，请稍后再试
        ///</summary>
        [Description("系统错误，请稍后再试")]
        _80000_系统错误请稍后再试 = 80000,
        ///<summary>
        ///参数格式校验错误
        ///</summary>
        [Description("参数格式校验错误")]
        _80001_参数格式校验错误 = 80001,
        ///<summary>
        ///签名失败
        ///</summary>
        [Description("签名失败")]
        _80002_签名失败 = 80002,
        ///<summary>
        ///该日期订单未生成
        ///</summary>
        [Description("该日期订单未生成")]
        _80003_该日期订单未生成 = 80003,
        ///<summary>
        ///用户未绑卡
        ///</summary>
        [Description("用户未绑卡")]
        _80004_用户未绑卡 = 80004,
        ///<summary>
        ///姓名不符
        ///</summary>
        [Description("姓名不符")]
        _80005_姓名不符 = 80005,
        ///<summary>
        ///身份证不符
        ///</summary>
        [Description("身份证不符")]
        _80006_身份证不符 = 80006,
        ///<summary>
        ///获取城市信息失败
        ///</summary>
        [Description("获取城市信息失败")]
        _80007_获取城市信息失败 = 80007,
        ///<summary>
        ///未找到指定少儿信息
        ///</summary>
        [Description("未找到指定少儿信息")]
        _80008_未找到指定少儿信息 = 80008,
        ///<summary>
        ///少儿身份证不符
        ///</summary>
        [Description("少儿身份证不符")]
        _80009_少儿身份证不符 = 80009,
        ///<summary>
        ///少儿未绑定
        ///</summary>
        [Description("少儿未绑定")]
        _80010_少儿未绑定 = 80010,
        ///<summary>
        ///签约号不符
        ///</summary>
        [Description("签约号不符")]
        _80011_签约号不符 = 80011,
        ///<summary>
        ///该地区局方配置不存在
        ///</summary>
        [Description("该地区局方配置不存在")]
        _80012_该地区局方配置不存在 = 80012,
        ///<summary>
        ///调用方appid与局方配置不匹配
        ///</summary>
        [Description("调用方appid与局方配置不匹配")]
        _80013_调用方appid与局方配置不匹配 = 80013,
        ///<summary>
        ///获取消息账号失败
        ///</summary>
        [Description("获取消息账号失败")]
        _80014_获取消息账号失败 = 80014,
        ///<summary>
        ///非法的插件版本
        ///</summary>
        [Description("非法的插件版本")]
        _80066_非法的插件版本 = 80066,
        ///<summary>
        ///找不到使用的插件
        ///</summary>
        [Description("找不到使用的插件")]
        _80067_找不到使用的插件 = 80067,
        ///<summary>
        ///没有权限使用该插件
        ///</summary>
        [Description("没有权限使用该插件")]
        _80082_没有权限使用该插件 = 80082,
        ///<summary>
        ///商家未接入
        ///</summary>
        [Description("商家未接入")]
        _80101_商家未接入 = 80101,
        ///<summary>
        ///实名校验code不存在
        ///</summary>
        [Description("实名校验code不存在")]
        _80111_实名校验code不存在 = 80111,
        ///<summary>
        ///code并发冲突
        ///</summary>
        [Description("code并发冲突")]
        _80112_Code并发冲突 = 80112,
        ///<summary>
        ///无效code
        ///</summary>
        [Description("无效code")]
        _80113_无效code = 80113,
        ///<summary>
        ///report_type无效
        ///</summary>
        [Description("report_type无效")]
        _80201_ReportType无效 = 80201,
        ///<summary>
        ///service_type无效
        ///</summary>
        [Description("service_type无效")]
        _80202_ServiceType无效 = 80202,
        ///<summary>
        ///申请单不存在
        ///</summary>
        [Description("申请单不存在")]
        _80300_申请单不存在 = 80300,
        ///<summary>
        ///申请单不属于该账号
        ///</summary>
        [Description("申请单不属于该账号")]
        _80301_申请单不属于该账号 = 80301,
        ///<summary>
        ///激活号段有重叠
        ///</summary>
        [Description("激活号段有重叠")]
        _80302_激活号段有重叠 = 80302,
        ///<summary>
        ///码格式错误
        ///</summary>
        [Description("码格式错误")]
        _80303_码格式错误 = 80303,
        ///<summary>
        ///该码未激活
        ///</summary>
        [Description("该码未激活")]
        _80304_该码未激活 = 80304,
        ///<summary>
        ///激活失败
        ///</summary>
        [Description("激活失败")]
        _80305_激活失败 = 80305,
        ///<summary>
        ///码索引超出申请范围
        ///</summary>
        [Description("码索引超出申请范围")]
        _80306_码索引超出申请范围 = 80306,
        ///<summary>
        ///申请已存在
        ///</summary>
        [Description("申请已存在")]
        _80307_申请已存在 = 80307,
        ///<summary>
        ///子任务未完成
        ///</summary>
        [Description("子任务未完成")]
        _80308_子任务未完成 = 80308,
        ///<summary>
        ///子任务文件过期
        ///</summary>
        [Description("子任务文件过期")]
        _80309_子任务文件过期 = 80309,
        ///<summary>
        ///子任务不存在
        ///</summary>
        [Description("子任务不存在")]
        _80310_子任务不存在 = 80310,
        ///<summary>
        ///获取文件失败
        ///</summary>
        [Description("获取文件失败")]
        _80311_获取文件失败 = 80311,
        ///<summary>
        ///加密数据失败
        ///</summary>
        [Description("加密数据失败")]
        _80312_加密数据失败 = 80312,
        ///<summary>
        ///加密数据密钥不存在，请联系接口人申请
        ///</summary>
        [Description("加密数据密钥不存在，请联系接口人申请")]
        _80313_加密数据密钥不存在请联系接口人申请 = 80313,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81000_CanNotSetPageIdInAddGiftCardPage = 81000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81001_CardListIsEmpty = 81001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81002_CardIdIsNotGiftcard = 81002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81004_BannerPicUrlIsEmpty = 81004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81005_BannerPicUrlIsNotFromCdn = 81005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81006_GiftcardWrapPicUrlListIsEmpty = 81006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81007_GiftcardWrapPicUrlListIsNotFromCdn = 81007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81008_AddressIsEmpty = 81008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81009_ServicePhoneIsInvalid = 81009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81010_BizDescriptionIsEmpty = 81010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81011_InvalidPageId = 81011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81012_InvalidOrderId = 81012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81013_InvalidTIMERANGEBeginTime31dayMustLessThanEndTime = 81013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81014_InvalidCountCountMustEqualOrLessThan100 = 81014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81015_InvalidCategoryIndexORCategoryTitleIsEmptyORIsBannerButHasCategoryIndex = 81015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81016_IsBannerIsMoreThan1 = 81016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81017_OrderStatusErrorPleaseCheckPayStatusOrGiftingStatus = 81017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81018_RefundReduplicateTheOrderIsAlreadyRefunded = 81018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81019_LockOrderFailTheOrderIsRefundingByAnotherRequest = 81019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81020_InvalidArgsPageIdSize0ButAllTrueOrPageIdSize0ButAllFalse = 81020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81021_EmptyThemePicUrl = 81021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81022_EmptyThemeTitle = 81022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81023_EmptyThemeTitleTitle = 81023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81024_EmptyThemeItemList = 81024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81025_EmptyThemePicItemList = 81025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81026_InvalidThemeTitleLength = 81026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81027_EmptyBackgroundPicUrl = 81027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81028_EmptyDefaultGiftingMsg = 81028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81029_DuplicateOrderId = 81029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81030_PreAllocCodeFail = 81030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _81031_TooManyThemeParticipateActivity = 81031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82000_BizTemplateIdNotExist = 82000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82001_ResultPageStyleIdNotExist = 82001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82002_DealMsgStyleIdNotExist = 82002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82003_CardStyleIdNotExist = 82003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82010_BizTemplateNotAuditOK = 82010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82011_BizTemplateBanned = 82011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82020_UserNotUseServiceFirst = 82020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82021_ExceedLongPeriod = 82021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82022_ExceedLongPeriodMaxSendCnt = 82022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82023_ExceedShortPeriodMaxSendCnt = 82023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82024_ExceedDataSizeLimit = 82024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82025_InvalidUrl = 82025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82026_ServiceDisabled = 82026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82027_InvalidMiniprogramAppid = 82027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82100_WxCsCodeShouldNotBeEmpty = 82100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82101_WxCsCodeIsInvalid = 82101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82102_WxCsCodeIsExpire = 82102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _82103_UserIpShouldNotBeEmpty = 82103,
        ///<summary>
        ///公众平台账号与服务id不匹配
        ///</summary>
        [Description("公众平台账号与服务id不匹配")]
        _82200_公众平台账号与服务id不匹配 = 82200,
        ///<summary>
        ///该停车场已存在，请勿重复添加
        ///</summary>
        [Description("该停车场已存在，请勿重复添加")]
        _82201_该停车场已存在请勿重复添加 = 82201,
        ///<summary>
        ///该停车场信息不存在，请先导入
        ///</summary>
        [Description("该停车场信息不存在，请先导入")]
        _82202_该停车场信息不存在请先导入 = 82202,
        ///<summary>
        ///停车场价格格式不正确
        ///</summary>
        [Description("停车场价格格式不正确")]
        _82203_停车场价格格式不正确 = 82203,
        ///<summary>
        ///appid与code不匹配
        ///</summary>
        [Description("appid与code不匹配")]
        _82204_Appid与code不匹配 = 82204,
        ///<summary>
        ///wx_park_code字段为空
        ///</summary>
        [Description("wx_park_code字段为空")]
        _82205_WxParkCode字段为空 = 82205,
        ///<summary>
        ///wx_park_code无效或已过期
        ///</summary>
        [Description("wx_park_code无效或已过期")]
        _82206_WxParkCode无效或已过期 = 82206,
        ///<summary>
        ///电话字段为空
        ///</summary>
        [Description("电话字段为空")]
        _82207_电话字段为空 = 82207,
        ///<summary>
        ///关闭时间格式不正确
        ///</summary>
        [Description("关闭时间格式不正确")]
        _82208_关闭时间格式不正确 = 82208,
        ///<summary>
        ///该appid不支持开通城市服务插件
        ///</summary>
        [Description("该appid不支持开通城市服务插件")]
        _82300_该appid不支持开通城市服务插件 = 82300,
        ///<summary>
        ///添加插件失败
        ///</summary>
        [Description("添加插件失败")]
        _82301_添加插件失败 = 82301,
        ///<summary>
        ///未添加城市服务插件
        ///</summary>
        [Description("未添加城市服务插件")]
        _82302_未添加城市服务插件 = 82302,
        ///<summary>
        ///fileid无效
        ///</summary>
        [Description("fileid无效")]
        _82303_Fileid无效 = 82303,
        ///<summary>
        ///临时文件过期
        ///</summary>
        [Description("临时文件过期")]
        _82304_临时文件过期 = 82304,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83000_ThereIsSomeParamNotExist = 83000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83001_SystemError = 83001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83002_CreateUrlSenceFailed = 83002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83003_AppidMaybeErrorOrRetry = 83003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83004_CreateAppidAuthFailedOrRetry = 83004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83005_WxwebencrytokenErrro = 83005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83006_WxwebencrytokenExpiredOrNoExist = 83006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83007_WxwebencrytokenExpired = 83007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83008_WxwebencrytokenNoAuth = 83008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83009_WxwebencrytokenNotTheMateWithOpenid = 83009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83200_NoExistService = 83200,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83201_UinHasNotTheService = 83201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83202_ParamsIsNotJsonOrNotJsonArray = 83202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83203_ParamsNumExceed10 = 83203,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83204_ObjectHasNotKey = 83204,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83205_KeyIsNotString = 83205,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83206_ObjectHasNotValue = 83206,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83207_ValueIsNotString = 83207,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83208_KeyOrValueIsEmpty = 83208,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _83209_KeyExistRepeated = 83209,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84001_InvalidIdentifyId = 84001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84002_UserDataExpired = 84002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84003_UserDataNotExist = 84003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84004_VideoUploadFail = 84004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84005_VideoDownloadFailPleaseTryAgain = 84005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _84006_NameOrIdCardNumberEmpty = 84006,
        ///<summary>
        ///微信号不存在或微信号设置为不可搜索
        ///</summary>
        [Description("微信号不存在或微信号设置为不可搜索")]
        _85001_UserNotExistOrUserCannotBeSearched = 85001,
        ///<summary>
        ///小程序绑定的体验者数量达到上限
        ///</summary>
        [Description("小程序绑定的体验者数量达到上限")]
        _85002_NumberOfTesterReachBindLimit = 85002,
        ///<summary>
        ///微信号绑定的小程序体验者达到上限
        ///</summary>
        [Description("微信号绑定的小程序体验者达到上限")]
        _85003_UserAlreadyBindTooManyWeapps = 85003,
        ///<summary>
        ///微信号已经绑定
        ///</summary>
        [Description("微信号已经绑定")]
        _85004_UserAlreadyBind = 85004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85005_AppidNotBindWeapp = 85005,
        ///<summary>
        ///标签格式错误
        ///</summary>
        [Description("标签格式错误")]
        _85006_TagIsInInvalidFormat = 85006,
        ///<summary>
        ///页面路径错误
        ///</summary>
        [Description("页面路径错误")]
        _85007_PageIsInInvalidFormat = 85007,
        ///<summary>
        ///类目填写错误
        ///</summary>
        [Description("类目填写错误")]
        _85008_CategoryIsInInvalidFormat = 85008,
        ///<summary>
        ///已经有正在审核的版本
        ///</summary>
        [Description("已经有正在审核的版本")]
        _85009_AlreadySubmitAVersionUnderAuditing = 85009,
        ///<summary>
        ///item_list 有项目为空
        ///</summary>
        [Description("item_list 有项目为空")]
        _85010_MissingRequiredData = 85010,
        ///<summary>
        ///标题填写错误
        ///</summary>
        [Description("标题填写错误")]
        _85011_TitleIsInInvalidFormat = 85011,
        ///<summary>
        ///无效的审核 id
        ///</summary>
        [Description("无效的审核 id")]
        _85012_InvalidAuditId = 85012,
        ///<summary>
        ///无效的自定义配置
        ///</summary>
        [Description("无效的自定义配置")]
        _85013_InvalidExtJsonParseFailOrContainingInvalidPath = 85013,
        ///<summary>
        ///无效的模板编号
        ///</summary>
        [Description("无效的模板编号")]
        _85014_TemplateNotExist = 85014,
        ///<summary>
        ///该账号不是小程序账号
        ///</summary>
        [Description("该账号不是小程序账号")]
        _85015_该账号不是小程序账号 = 85015,
        ///<summary>
        ///版本输入错误
        ///</summary>
        [Description("版本输入错误")]
        _85015_版本输入错误 = 85015,
        ///<summary>
        ///域名数量超过限制 ，总数不能超过1000
        ///</summary>
        [Description("域名数量超过限制 ，总数不能超过1000")]
        _85016_ExceedValidDomainCount = 85016,
        ///<summary>
        ///没有新增域名，请确认小程序已经添加了域名或该域名是否没有在第三方平台添加
        ///</summary>
        [Description("没有新增域名，请确认小程序已经添加了域名或该域名是否没有在第三方平台添加")]
        _85017_NoDomainToModifyAfterFilteredPleaseConfirmTheDomainHasBeenSetInMiniprogramOrOpen = 85017,
        ///<summary>
        ///域名没有在第三方平台设置
        ///</summary>
        [Description("域名没有在第三方平台设置")]
        _85018_域名没有在第三方平台设置 = 85018,
        ///<summary>
        ///没有审核版本
        ///</summary>
        [Description("没有审核版本")]
        _85019_NoVersionIsUnderAuditing = 85019,
        ///<summary>
        ///审核状态未满足发布
        ///</summary>
        [Description("审核状态未满足发布")]
        _85020_StatusNotAllowed = 85020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85021_StatusNotAllowed = 85021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85022_InvalidAction = 85022,
        ///<summary>
        ///审核列表填写的项目数不在 1-5 以内
        ///</summary>
        [Description("审核列表填写的项目数不在 1-5 以内")]
        _85023_ItemSizeIsNotInValidRange = 85023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85024_NeedCompleteMaterial = 85024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85025_ThisPhoneReachBindLimit = 85025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85026_ThisWechatAccountReachBindLimit = 85026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85027_ThisIdcardReachBindLimit = 85027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85028_ThisContractorReachBindLimit = 85028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85029_NicknameHasUsed = 85029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85030_InvalidNicknameSize430 = 85030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85031_NicknameIsForbidden = 85031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85032_NicknameIsComplained = 85032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85033_NicknameIsIllegal = 85033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85034_NicknameIsProtected = 85034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85035_NicknameIsForbiddenForDifferentContractor = 85035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85036_IntroductionIsIllegal = 85036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85038_StoreHasAdded = 85038,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85039_StoreHasAddedByOthers = 85039,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85040_StoreHasAddedByYourseld = 85040,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85041_CredentialHasUsed = 85041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85042_NearbyReachLimit = 85042,
        ///<summary>
        ///模板错误
        ///</summary>
        [Description("模板错误")]
        _85043_InvalidTemplateSomethingWrong = 85043,
        ///<summary>
        ///代码包超过大小限制
        ///</summary>
        [Description("代码包超过大小限制")]
        _85044_PackageExceedMaxLimit = 85044,
        ///<summary>
        ///ext_json 有不存在的路径
        ///</summary>
        [Description("ext_jso 有不存在的路径")]
        _85045_SomePathInExtJsonNotExist = 85045,
        ///<summary>
        ///tabBar 中缺少 path
        ///</summary>
        [Description("tabBar 中缺少 path")]
        _85046_PagepathMissingInTabbarList = 85046,
        ///<summary>
        ///pages 字段为空
        ///</summary>
        [Description("pages 字段为空")]
        _85047_PagesAreEmpty = 85047,
        ///<summary>
        ///ext_json 解析失败
        ///</summary>
        [Description("ext_jso 解析失败")]
        _85048_ParseExtJsonFail = 85048,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85049_ReachHeadimgOrIntroductionQuotaLimit = 85049,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85050_VerifyingDonTApplyAgain = 85050,
        ///<summary>
        ///version_desc或者preview_info超限
        ///</summary>
        [Description("versio_desc或者preview_ifo超限")]
        _85051_DataTooLarge = 85051,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85052_AppIsAlreadyReleased = 85052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85053_PleaseApplyMerchantFirst = 85053,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85054_PoiIdIsNullPleaseUpgradeFirst = 85054,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85055_MapPoiIdIsInvalid = 85055,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85056_MediaidIsInvalid = 85056,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85057_InvalidWidgetDataFormat = 85057,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85058_NoValidAuditIdExist = 85058,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85059_OverseasAccessDeny = 85059,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85060_InvalidTaskid = 85060,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85061_ThisPhoneReachBindLimit = 85061,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85062_ThisPhoneInBlackList = 85062,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85063_IdcardInBlackList = 85063,
        ///<summary>
        ///找不到模板
        ///</summary>
        [Description("找不到模板")]
        _85064_TemplateNotFound = 85064,
        ///<summary>
        ///模板库已满
        ///</summary>
        [Description("模板库已满")]
        _85065_TemplateListIsFull = 85065,
        ///<summary>
        ///链接错误
        ///</summary>
        [Description("链接错误")]
        _85066_IllegalPrefix = 85066,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85067_InputDataError = 85067,
        ///<summary>
        ///测试链接不是子链接
        ///</summary>
        [Description("测试链接不是子链接")]
        _85068_TestUrlIsNotTheSubPrefix = 85068,
        ///<summary>
        ///校验文件失败
        ///</summary>
        [Description("校验文件失败")]
        _85069_CheckConfirmFileFail = 85069,
        ///<summary>
        ///个人类型小程序无法设置二维码规则
        ///</summary>
        [Description("个人类型小程序无法设置二维码规则")]
        _85070_PrefixInBlackList = 85070,
        ///<summary>
        ///已添加该链接，请勿重复添加
        ///</summary>
        [Description("已添加该链接，请勿重复添加")]
        _85071_PrefixAddedRepeated = 85071,
        ///<summary>
        ///该链接已被占用
        ///</summary>
        [Description("该链接已被占用")]
        _85072_PrefixOwnedByOther = 85072,
        ///<summary>
        ///二维码规则已满
        ///</summary>
        [Description("二维码规则已满")]
        _85073_PrefixBeyondLimit = 85073,
        ///<summary>
        ///小程序未发布, 小程序必须先发布代码才可以发布二维码跳转规则
        ///</summary>
        [Description("小程序未发布, 小程序必须先发布代码才可以发布二维码跳转规则")]
        _85074_NotPublished = 85074,
        ///<summary>
        ///个人类型小程序无法设置二维码规则
        ///</summary>
        [Description("个人类型小程序无法设置二维码规则")]
        _85075_CanNotAccess = 85075,
        ///<summary>
        ///小程序类目信息失效（类目中含有官方下架的类目，请重新选择类目）
        ///</summary>
        [Description("小程序类目信息失效（类目中含有官方下架的类目，请重新选择类目）")]
        _85077_SomeCategoryYouChooseIsNoLonggerSupportedPleaseChooseOtherCategory = 85077,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85078_OperatorInfoError = 85078,
        ///<summary>
        ///小程序没有线上版本，不能进行灰度
        ///</summary>
        [Description("小程序没有线上版本，不能进行灰度")]
        _85079_MiniprogramHasNoOnlineRelease = 85079,
        ///<summary>
        ///小程序提交的审核未审核通过
        ///</summary>
        [Description("小程序提交的审核未审核通过")]
        _85080_MiniprogramCommitNotApproved = 85080,
        ///<summary>
        ///无效的发布比例
        ///</summary>
        [Description("无效的发布比例")]
        _85081_InvalidGrayPercentage = 85081,
        ///<summary>
        ///当前的发布比例需要比之前设置的高
        ///</summary>
        [Description("当前的发布比例需要比之前设置的高")]
        _85082_GrayPercentageTooLow = 85082,
        ///<summary>
        ///搜索标记位被封禁，无法修改
        ///</summary>
        [Description("搜索标记位被封禁，无法修改")]
        _85083_SearchStatusIsBanned = 85083,
        ///<summary>
        ///非法的 status 值，只能填 0 或者 1
        ///</summary>
        [Description("非法的 status 值，只能填 0 或者 1")]
        _85084_SearchStatusInvalid = 85084,
        ///<summary>
        ///小程序提审数量已达本月上限，请点击查看《临时quota申请流程》
        ///</summary>
        [Description("小程序提审数量已达本月上限，请点击查看《临时quota申请流程》")]
        _85085_小程序提审数量已达本月上限请点击查看临时quota申请流程 = 85085,
        ///<summary>
        ///提交代码审核之前需提前上传代码
        ///</summary>
        [Description("提交代码审核之前需提前上传代码")]
        _85086_MustCommitBeforeSubmitAudit = 85086,
        ///<summary>
        ///小程序已使用 api navigateToMiniProgram，请声明跳转 appid 列表后再次提交
        ///</summary>
        [Description("小程序已使用 api avigateToMiiProgram，请声明跳转 appid 列表后再次提交")]
        _85087_NavigatetominiprogramAppidListEmpty = 85087,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85088_NoQbasePrivilege = 85088,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85089_ConfigNotFound = 85089,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _85090_WaitAndCommitForThisExappidLater = 85090,
        ///<summary>
        ///小程序的搜索开关被关闭。请访问设置页面打开开关再重试
        ///</summary>
        [Description("小程序的搜索开关被关闭。请访问设置页面打开开关再重试")]
        _85091_SearchStatusWasTurnedOff = 85091,
        ///<summary>
        ///preview_info格式错误
        ///</summary>
        [Description("preview_ifo格式错误")]
        _85092_InvalidPreviewInfoFormat = 85092,
        ///<summary>
        ///preview_info 视频或者图片个数超限
        ///</summary>
        [Description("preview_ifo 视频或者图片个数超限")]
        _85093_InvalidPreviewInfoSize = 85093,
        ///<summary>
        ///需提供审核机制说明信息
        ///</summary>
        [Description("需提供审核机制说明信息")]
        _85094_NeedAddUgcDeclare = 85094,
        ///<summary>
        ///小程序不能发送该运动类型或运动类型不存在
        ///</summary>
        [Description("小程序不能发送该运动类型或运动类型不存在")]
        _85101_小程序不能发送该运动类型或运动类型不存在 = 85101,
        ///<summary>
        ///数值异常
        ///</summary>
        [Description("数值异常")]
        _85102_数值异常 = 85102,
        ///<summary>
        ///不是由第三方代小程序进行调用
        ///</summary>
        [Description("不是由第三方代小程序进行调用")]
        _86000_ShouldBeCalledOnlyFromThirdParty = 86000,
        ///<summary>
        ///不存在第三方的已经提交的代码
        ///</summary>
        [Description("不存在第三方的已经提交的代码")]
        _86001_ComponentExperienceVersionNotExists = 86001,
        ///<summary>
        ///小程序还未设置昵称、头像、简介。请先设置完后再重新提交
        ///</summary>
        [Description("小程序还未设置昵称、头像、简介。请先设置完后再重新提交")]
        _86002_MiniprogramHaveNotCompletedInitProcedure = 86002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _86003_ComponentDoNotHasCategoryMall = 86003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _86004_InvalidWechat = 86004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _86005_WechatLimitFrequency = 86005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _86006_HasNoQuotaToSendGroupMsg = 86006,
        ///<summary>
        ///小程序禁止提交
        ///</summary>
        [Description("小程序禁止提交")]
        _86007_小程序禁止提交 = 86007,
        ///<summary>
        ///服务商被处罚，限制全部代码提审能力
        ///</summary>
        [Description("服务商被处罚，限制全部代码提审能力")]
        _86008_服务商被处罚限制全部代码提审能力 = 86008,
        ///<summary>
        ///服务商新增小程序代码提审能力被限制
        ///</summary>
        [Description("服务商新增小程序代码提审能力被限制")]
        _86009_服务商新增小程序代码提审能力被限制 = 86009,
        ///<summary>
        ///服务商迭代小程序代码提审能力被限制
        ///</summary>
        [Description("服务商迭代小程序代码提审能力被限制")]
        _86010_服务商迭代小程序代码提审能力被限制 = 86010,
        ///<summary>
        ///小游戏不能提交
        ///</summary>
        [Description("小游戏不能提交")]
        _87006_ThisIsGameMiniprogramSubmitAuditIsForbidden = 87006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87007_SessionKeyIsNotExistdOrExpired = 87007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87008_InvalidSigMethod = 87008,
        ///<summary>
        ///无效的签名
        ///</summary>
        [Description("无效的签名")]
        _87009_InvalidSignature = 87009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87010_InvalidBufferSize = 87010,
        ///<summary>
        ///现网已经在灰度发布，不能进行版本回退
        ///</summary>
        [Description("现网已经在灰度发布，不能进行版本回退")]
        _87011_WxaHasAGrayReleasePlanForbidRevertRelease = 87011,
        ///<summary>
        ///该版本不能回退，可能的原因：1:无上一个线上版用于回退 2:此版本为已回退版本，不能回退 3:此版本为回退功能上线之前的版本，不能回退
        ///</summary>
        [Description("该版本不能回退，可能的原因：1:无上一个线上版用于回退 2:此版本为已回退版本，不能回退 3:此版本为回退功能上线之前的版本，不能回退")]
        _87012_ForbidRevertThisVersionRelease = 87012,
        ///<summary>
        ///撤回次数达到上限（每天一次，每个月 10 次）
        ///</summary>
        [Description("撤回次数达到上限（每天一次，每个月 10 次）")]
        _87013_NoQuotaToUndoCode = 87013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87014_RiskyContent = 87014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87015_QueryTimeoutTryAContentWithLessSize = 87015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87016_SomeKeyValueInListMeetLengthExceed = 87016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87017_UserStorageSizeExceedDeleteSomeKeysAndTryAgain = 87017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87018_UserHasStoredTooMuchKeysDeleteSomeKeysAndTryAgain = 87018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87019_SomeKeysInListMeetLengthExceed = 87019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87080_NeedFriend = 87080,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87081_InvalidOpenid = 87081,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87082_InvalidKey = 87082,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87083_InvalidOperation = 87083,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87084_InvalidOpnum = 87084,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _87085_CheckFail = 87085,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88000_WithoutCommentPrivilege = 88000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88001_MsgDataIsNotExists = 88001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88002_TheArticleIsLimitForSafety = 88002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88003_ElectedCommentUpperLimit = 88003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88004_CommentWasDeletedByUser = 88004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88005_AlreadyReply = 88005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88007_ReplyContentBeyondMaxLenOrContentLenIsZero = 88007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88008_CommentIsNotExists = 88008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88009_ReplyIsNotExists = 88009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88010_CountRangeErrorCoutLt0OrCountGt50 = 88010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _88011_TheArticleIsLimitForSafety = 88011,
        ///<summary>
        ///account has bound open，该公众号/小程序已经绑定了开放平台帐号
        ///</summary>
        [Description("accout has boud ope，该公众号/小程序已经绑定了开放平台帐号")]
        _89000_AccountHasBoundOpen = 89000,
        ///<summary>
        ///not same contractor，Authorizer 与开放平台帐号主体不相同
        ///</summary>
        [Description("ot same cotractor，Authorizer 与开放平台帐号主体不相同")]
        _89001_NotSameContractor = 89001,
        ///<summary>
        ///open not exists，该公众号/小程序未绑定微信开放平台帐号。
        ///</summary>
        [Description("ope ot exists，该公众号/小程序未绑定微信开放平台帐号。")]
        _89002_OpenNotExists = 89002,
        ///<summary>
        ///该开放平台帐号并非通过 api 创建，不允许操作
        ///</summary>
        [Description("该开放平台帐号并非通过 api 创建，不允许操作")]
        _89003_OpenIsNotCreatedByApi = 89003,
        ///<summary>
        ///该开放平台帐号所绑定的公众号/小程序已达上限（100  个）
        ///</summary>
        [Description("该开放平台帐号所绑定的公众号/小程序已达上限（100  个）")]
        _89004_该开放平台帐号所绑定的公众号小程序已达上限100个 = 89004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89005_WithoutAddVideoAbilityTheAbilityWasBanned = 89005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89006_WithoutUploadVideoAbilityTheAbilityWasBanned = 89006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89007_WxaQuotaLimit = 89007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89008_OverseasAccountCanNotLink = 89008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89009_WxaReachLinkLimit = 89009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89010_LinkMessageHasSent = 89010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89011_CanNotUnlinkNearbyWxa = 89011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89012_CanNotUnlinkStoreOrMall = 89012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89013_WxaIsBanned = 89013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89014_SupportVersionError = 89014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89015_HasLinkedWxa = 89015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89016_ReachSameRealnameQuota = 89016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89017_ReachDifferentRealnameQuota = 89017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89018_UnlinkMessageHasSent = 89018,
        ///<summary>
        ///业务域名无更改，无需重复设置
        ///</summary>
        [Description("业务域名无更改，无需重复设置")]
        _89019_WebviewDomainNotChange = 89019,
        ///<summary>
        ///尚未设置小程序业务域名，请先在第三方平台中设置小程序业务域名后在调用本接口
        ///</summary>
        [Description("尚未设置小程序业务域名，请先在第三方平台中设置小程序业务域名后在调用本接口")]
        _89020_OpenSWebviewDomainIsNullNeedToSetOpenSWebviewDomainFirst = 89020,
        ///<summary>
        ///请求保存的域名不是第三方平台中已设置的小程序业务域名或子域名
        ///</summary>
        [Description("请求保存的域名不是第三方平台中已设置的小程序业务域名或子域名")]
        _89021_RequestDomainIsNotOpenSWebviewDomain = 89021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89022_DeleteDomainIsNotExist = 89022,
        ///<summary>
        ///业务域名数量超过限制，最多可以添加100个业务域名
        ///</summary>
        [Description("业务域名数量超过限制，最多可以添加100个业务域名")]
        _89029_WebviewDomainExceedLimit = 89029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89030_OperationReachMonthLimit = 89030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89031_UserBindReachLimit = 89031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89032_WeappBindMembersReachLimit = 89032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89033_EmptyWxOrOpenid = 89033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89034_UserstrIsInvalid = 89034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89035_LinkingFromMp = 89035,
        ///<summary>
        ///个人小程序不支持调用 setwebviewdomain 接口
        ///</summary>
        [Description("个人小程序不支持调用 setwebviewdomai 接口")]
        _89231_NotSupportSingle = 89231,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89235_HitBlackContractor = 89235,
        ///<summary>
        ///该插件不能申请
        ///</summary>
        [Description("该插件不能申请")]
        _89236_ThisPluginCanNotApply = 89236,
        ///<summary>
        ///已经添加该插件
        ///</summary>
        [Description("已经添加该插件")]
        _89237_PluginHasSendApplyMessageOrAlreadyBind = 89237,
        ///<summary>
        ///申请或使用的插件已经达到上限
        ///</summary>
        [Description("申请或使用的插件已经达到上限")]
        _89238_PluginCountReachLimit = 89238,
        ///<summary>
        ///该插件不存在
        ///</summary>
        [Description("该插件不存在")]
        _89239_PluginNoExist = 89239,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89240_OnlyApplyingStatusCanBeAgreedOrRefused = 89240,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89241_OnlyRefusedStatusCanBeDeletedPleaseRefusedFirst = 89241,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89242_AppidIsNoInTheApplyListMakeSureAppidIsRight = 89242,
        ///<summary>
        ///该申请为“待确认”状态，不可删除
        ///</summary>
        [Description("该申请为“待确认”状态，不可删除")]
        _89243_CanNotDeleteApplyRequestIn24Hours = 89243,
        ///<summary>
        ///不存在该插件 appid
        ///</summary>
        [Description("不存在该插件 appid")]
        _89244_PluginAppidIsNoInThePluginListMakeSurePluginAppidIsRight = 89244,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89245_MiniProgramForbiddenToLink = 89245,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89246_PluginsWithSpecialCategoryAreUsedOnlyBySpecificApps = 89246,
        ///<summary>
        ///该公众号/小程序 已经绑定了开放平台帐号
        ///</summary>
        [Description("该公众号/小程序 已经绑定了开放平台帐号")]
        _89247_该公众号小程序已经绑定了开放平台帐号 = 89247,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89248_InvalidCodeType = 89248,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89249_TaskRunning = 89249,
        ///<summary>
        ///内部错误
        ///</summary>
        [Description("内部错误")]
        _89250_InnerErrorRetryAfterSomeWhile = 89250,
        ///<summary>
        ///未找到该任务
        ///</summary>
        [Description("未找到该任务")]
        _89251_TaskNotFound = 89251,
        ///<summary>
        ///模板消息已下发，待法人人脸核身校验
        ///</summary>
        [Description("模板消息已下发，待法人人脸核身校验")]
        _89252_LegalPersonaChecking = 89252,
        ///<summary>
        ///法人&amp;企业信息一致性校验中
        ///</summary>
        [Description("法人&amp;企业信息一致性校验中")]
        _89253_FrontChecking = 89253,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89254_LackOfSomeComponentRights = 89254,
        ///<summary>
        ///code参数无效，请检查code长度以及内容是否正确；注意code_type的值不同需要传的code长度不一样
        ///</summary>
        [Description("code参数无效，请检查code长度以及内容是否正确；注意code_type的值不同需要传的code长度不一样")]
        _89255_EnterpriseCodeInvalid = 89255,
        ///<summary>
        ///token 信息有误
        ///</summary>
        [Description("toke 信息有误")]
        _89256_NoComponentInfo = 89256,
        ///<summary>
        ///该插件版本不支持快速更新
        ///</summary>
        [Description("该插件版本不支持快速更新")]
        _89257_NoSuchVersion = 89257,
        ///<summary>
        ///当前小程序帐号存在灰度发布中的版本，不可操作快速更新
        ///</summary>
        [Description("当前小程序帐号存在灰度发布中的版本，不可操作快速更新")]
        _89258_CodeIsGrayOnline = 89258,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _89259_ZhiboPluginIsNotAllowToDelete = 89259,
        ///<summary>
        ///订单无效
        ///</summary>
        [Description("订单无效")]
        _89300_InvalidTrade = 89300,
        ///<summary>
        ///系统不稳定，请稍后再试，如多次失败请通过社区反馈
        ///</summary>
        [Description("系统不稳定，请稍后再试，如多次失败请通过社区反馈")]
        _89401_系统不稳定请稍后再试如多次失败请通过社区反馈 = 89401,
        ///<summary>
        ///该小程序不在待审核队列，请检查是否已提交审核或已审完
        ///</summary>
        [Description("该小程序不在待审核队列，请检查是否已提交审核或已审完")]
        _89402_该小程序不在待审核队列请检查是否已提交审核或已审完 = 89402,
        ///<summary>
        ///本单属于平台不支持加急种类，请等待正常审核流程
        ///</summary>
        [Description("本单属于平台不支持加急种类，请等待正常审核流程")]
        _89403_本单属于平台不支持加急种类请等待正常审核流程 = 89403,
        ///<summary>
        ///本单已加速成功，请勿重复提交
        ///</summary>
        [Description("本单已加速成功，请勿重复提交")]
        _89404_本单已加速成功请勿重复提交 = 89404,
        ///<summary>
        ///本月加急额度已用完，请提高提审质量以获取更多额度
        ///</summary>
        [Description("本月加急额度已用完，请提高提审质量以获取更多额度")]
        _89405_本月加急额度已用完请提高提审质量以获取更多额度 = 89405,
        ///<summary>
        ///公众号有未处理的确认请求，请稍候重试
        ///</summary>
        [Description("公众号有未处理的确认请求，请稍候重试")]
        _89501_公众号有未处理的确认请求请稍候重试 = 89501,
        ///<summary>
        ///请耐心等待管理员确认
        ///</summary>
        [Description("请耐心等待管理员确认")]
        _89502_请耐心等待管理员确认 = 89502,
        ///<summary>
        ///此次调用需要管理员确认，请耐心等候
        ///</summary>
        [Description("此次调用需要管理员确认，请耐心等候")]
        _89503_此次调用需要管理员确认请耐心等候 = 89503,
        ///<summary>
        ///正在等管理员确认，请耐心等待
        ///</summary>
        [Description("正在等管理员确认，请耐心等待")]
        _89504_正在等管理员确认请耐心等待 = 89504,
        ///<summary>
        ///正在等管理员确认，请稍候重试
        ///</summary>
        [Description("正在等管理员确认，请稍候重试")]
        _89505_正在等管理员确认请稍候重试 = 89505,
        ///<summary>
        ///该IP调用求请求已被公众号管理员拒绝，请24小时后再试，建议调用前与管理员沟通确认
        ///</summary>
        [Description("该IP调用求请求已被公众号管理员拒绝，请24小时后再试，建议调用前与管理员沟通确认")]
        _89506_该IP调用求请求已被公众号管理员拒绝请24小时后再试建议调用前与管理员沟通确认 = 89506,
        ///<summary>
        ///该IP调用求请求已被公众号管理员拒绝，请1小时后再试，建议调用前与管理员沟通确认
        ///</summary>
        [Description("该IP调用求请求已被公众号管理员拒绝，请1小时后再试，建议调用前与管理员沟通确认")]
        _89507_该IP调用求请求已被公众号管理员拒绝请1小时后再试建议调用前与管理员沟通确认 = 89507,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90001_InvalidOrderId = 90001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90002_InvalidBusiId = 90002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90003_InvalidBillDate = 90003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90004_InvalidBillType = 90004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90005_InvalidPlatform = 90005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90006_BillNotExists = 90006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90007_InvalidOpenid = 90007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90009_MpSigError = 90009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90010_NoSession = 90010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90011_SigError = 90011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90012_OrderExist = 90012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90013_BalanceNotEnough = 90013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90014_OrderHasBeenConfirmed = 90014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90015_OrderHasBeenCanceled = 90015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90016_OrderIsBeingProcessed = 90016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90017_NoPrivilege = 90017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _90018_InvalidParameter = 90018,
        ///<summary>
        ///不是公众号快速创建的小程序
        ///</summary>
        [Description("不是公众号快速创建的小程序")]
        _91001_NotFastRegister = 91001,
        ///<summary>
        ///小程序发布后不可改名
        ///</summary>
        [Description("小程序发布后不可改名")]
        _91002_HasPublished = 91002,
        ///<summary>
        ///改名状态不合法
        ///</summary>
        [Description("改名状态不合法")]
        _91003_InvalidChangeStat = 91003,
        ///<summary>
        ///昵称不合法
        ///</summary>
        [Description("昵称不合法")]
        _91004_InvalidNickname = 91004,
        ///<summary>
        ///昵称 15 天主体保护
        ///</summary>
        [Description("昵称 15 天主体保护")]
        _91005_NicknameProtected = 91005,
        ///<summary>
        ///昵称命中微信号
        ///</summary>
        [Description("昵称命中微信号")]
        _91006_NicknameUsedByUsername = 91006,
        ///<summary>
        ///昵称已被占用
        ///</summary>
        [Description("昵称已被占用")]
        _91007_NicknameUsed = 91007,
        ///<summary>
        ///昵称命中 7 天侵权保护期
        ///</summary>
        [Description("昵称命中 7 天侵权保护期")]
        _91008_NicknameProtected = 91008,
        ///<summary>
        ///需要提交材料
        ///</summary>
        [Description("需要提交材料")]
        _91009_NicknameNeedProof = 91009,
        ///<summary>
        ///其他错误
        ///</summary>
        [Description("其他错误")]
        _91010_其他错误 = 91010,
        ///<summary>
        ///查不到昵称修改审核单信息
        ///</summary>
        [Description("查不到昵称修改审核单信息")]
        _91011_查不到昵称修改审核单信息 = 91011,
        ///<summary>
        ///其它错误
        ///</summary>
        [Description("其它错误")]
        _91012_其它错误 = 91012,
        ///<summary>
        ///占用名字过多
        ///</summary>
        [Description("占用名字过多")]
        _91013_LockNameTooMore = 91013,
        ///<summary>
        ///+号规则 同一类型关联名主体不一致
        ///</summary>
        [Description("+号规则 同一类型关联名主体不一致")]
        _91014_DiffMasterPlus = 91014,
        ///<summary>
        ///原始名不同类型主体不一致
        ///</summary>
        [Description("原始名不同类型主体不一致")]
        _91015_DiffMaster = 91015,
        ///<summary>
        ///名称占用者 ≥2
        ///</summary>
        [Description("名称占用者 ≥2")]
        _91016_NameMoreOwner = 91016,
        ///<summary>
        ///+号规则 不同类型关联名主体不一致
        ///</summary>
        [Description("+号规则 不同类型关联名主体不一致")]
        _91017_OtherDiffMasterPlus = 91017,
        ///<summary>
        ///组织类型小程序发布后，侵权被清空昵称，需走认证改名
        ///</summary>
        [Description("组织类型小程序发布后，侵权被清空昵称，需走认证改名")]
        _91018_组织类型小程序发布后侵权被清空昵称需走认证改名 = 91018,
        ///<summary>
        ///小程序正在审核中
        ///</summary>
        [Description("小程序正在审核中")]
        _91019_小程序正在审核中 = 91019,
        ///<summary>
        ///该经营资质已添加，请勿重复添加
        ///</summary>
        [Description("该经营资质已添加，请勿重复添加")]
        _92000_该经营资质已添加请勿重复添加 = 92000,
        ///<summary>
        ///附近地点添加数量达到上线，无法继续添加
        ///</summary>
        [Description("附近地点添加数量达到上线，无法继续添加")]
        _92002_附近地点添加数量达到上线无法继续添加 = 92002,
        ///<summary>
        ///地点已被其它小程序占用
        ///</summary>
        [Description("地点已被其它小程序占用")]
        _92003_地点已被其它小程序占用 = 92003,
        ///<summary>
        ///附近功能被封禁
        ///</summary>
        [Description("附近功能被封禁")]
        _92004_附近功能被封禁 = 92004,
        ///<summary>
        ///地点正在审核中
        ///</summary>
        [Description("地点正在审核中")]
        _92005_地点正在审核中 = 92005,
        ///<summary>
        ///地点正在展示小程序
        ///</summary>
        [Description("地点正在展示小程序")]
        _92006_地点正在展示小程序 = 92006,
        ///<summary>
        ///地点审核失败
        ///</summary>
        [Description("地点审核失败")]
        _92007_地点审核失败 = 92007,
        ///<summary>
        ///小程序未展示在该地点
        ///</summary>
        [Description("小程序未展示在该地点")]
        _92008_小程序未展示在该地点 = 92008,
        ///<summary>
        ///小程序未上架或不可见
        ///</summary>
        [Description("小程序未上架或不可见")]
        _93009_小程序未上架或不可见 = 93009,
        ///<summary>
        ///地点不存在
        ///</summary>
        [Description("地点不存在")]
        _93010_地点不存在 = 93010,
        ///<summary>
        ///个人类型小程序不可用
        ///</summary>
        [Description("个人类型小程序不可用")]
        _93011_个人类型小程序不可用 = 93011,
        ///<summary>
        ///非普通类型小程序（门店小程序、小店小程序等）不可用
        ///</summary>
        [Description("非普通类型小程序（门店小程序、小店小程序等）不可用")]
        _93012_非普通类型小程序门店小程序小店小程序等不可用 = 93012,
        ///<summary>
        ///从腾讯地图获取地址详细信息失败
        ///</summary>
        [Description("从腾讯地图获取地址详细信息失败")]
        _93013_从腾讯地图获取地址详细信息失败 = 93013,
        ///<summary>
        ///同一资质证件号重复添加
        ///</summary>
        [Description("同一资质证件号重复添加")]
        _93014_同一资质证件号重复添加 = 93014,
        ///<summary>
        ///附近类目审核中
        ///</summary>
        [Description("附近类目审核中")]
        _93015_附近类目审核中 = 93015,
        ///<summary>
        ///服务标签个数超限制（官方最多5个，自定义最多4个）
        ///</summary>
        [Description("服务标签个数超限制（官方最多5个，自定义最多4个）")]
        _93016_服务标签个数超限制官方最多5个自定义最多4个 = 93016,
        ///<summary>
        ///服务标签或者客服的名字不符合要求
        ///</summary>
        [Description("服务标签或者客服的名字不符合要求")]
        _93017_服务标签或者客服的名字不符合要求 = 93017,
        ///<summary>
        ///服务能力中填写的小程序appid不是同主体小程序
        ///</summary>
        [Description("服务能力中填写的小程序appid不是同主体小程序")]
        _93018_服务能力中填写的小程序appid不是同主体小程序 = 93018,
        ///<summary>
        ///申请类目之后才能添加附近地点
        ///</summary>
        [Description("申请类目之后才能添加附近地点")]
        _93019_申请类目之后才能添加附近地点 = 93019,
        ///<summary>
        ///qualification_list无效
        ///</summary>
        [Description("qualificatio_list无效")]
        _93020_QualificationList无效 = 93020,
        ///<summary>
        ///company_name字段为空
        ///</summary>
        [Description("compay_ame字段为空")]
        _93021_CompanyName字段为空 = 93021,
        ///<summary>
        ///credential字段为空
        ///</summary>
        [Description("credetial字段为空")]
        _93022_Credential字段为空 = 93022,
        ///<summary>
        ///address字段为空
        ///</summary>
        [Description("address字段为空")]
        _93023_Address字段为空 = 93023,
        ///<summary>
        ///qualification_list字段为空
        ///</summary>
        [Description("qualificatio_list字段为空")]
        _93024_QualificationList字段为空 = 93024,
        ///<summary>
        ///服务appid对应的path不存在
        ///</summary>
        [Description("服务appid对应的path不存在")]
        _93025_服务appid对应的path不存在 = 93025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94001_MissingCertSerialno = 94001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94002_UseNotRegisterWechatPay = 94002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94003_InvalidSign = 94003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94004_UserDoNotHasRealNameInfo = 94004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94005_InvalidUserToken = 94005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94006_AppidUnauthorized = 94006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94007_AppidUnbindMchid = 94007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94008_InvalidTimestamp = 94008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94009_InvalidCertSerialnoCertSerialnoSSizeShouldBe40 = 94009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94010_InvalidMchId = 94010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _94011_TimestampExpired = 94011,
        ///<summary>
        ///appid和商户号的绑定关系不存在
        ///</summary>
        [Description("appid和商户号的绑定关系不存在")]
        _94012_Appid和商户号的绑定关系不存在 = 94012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95001_WxcodeDecodeFail = 95001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95002_WxcodeRecognizeUnautuorized = 95002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95101_GetProductByPageArgsInvalid = 95101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95102_GetProductMaterialsByCondArgsInvalid = 95102,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95103_MaterialIdListSizeOutOfLimit = 95103,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95104_ImportProductFrequenceOutOfLimit = 95104,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95105_MpIsImportingProductsApiIsRejectedToImport = 95105,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _95106_ApiIsRejectedToImportNeedToSetCommissionRatioOnMpFirst = 95106,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _101000_InvalidImageUrl = 101000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _101001_CertificateNotFound = 101001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _101002_NotEnoughMarketQuota = 101002,
        ///<summary>
        ///入参错误
        ///</summary>
        [Description("入参错误")]
        _200002_入参错误 = 200002,
        ///<summary>
        ///此账号已被封禁，无法操作
        ///</summary>
        [Description("此账号已被封禁，无法操作")]
        _200011_此账号已被封禁无法操作 = 200011,
        ///<summary>
        ///个人模板数已达上限，上限25个
        ///</summary>
        [Description("个人模板数已达上限，上限25个")]
        _200012_个人模板数已达上限上限25个 = 200012,
        ///<summary>
        ///此模板已被封禁，无法选用
        ///</summary>
        [Description("此模板已被封禁，无法选用")]
        _200013_此模板已被封禁无法选用 = 200013,
        ///<summary>
        ///模板  tid 参数错误
        ///</summary>
        [Description("模板  tid 参数错误")]
        _200014_模板Tid参数错误 = 200014,
        ///<summary>
        ///start  参数错误
        ///</summary>
        [Description("start  参数错误")]
        _200016_Start参数错误 = 200016,
        ///<summary>
        ///limit  参数错误
        ///</summary>
        [Description("limit  参数错误")]
        _200017_Limit参数错误 = 200017,
        ///<summary>
        ///类目  ids 缺失
        ///</summary>
        [Description("类目  ids 缺失")]
        _200018_类目Ids缺失 = 200018,
        ///<summary>
        ///类目  ids 不合法
        ///</summary>
        [Description("类目  ids 不合法")]
        _200019_类目Ids不合法 = 200019,
        ///<summary>
        ///关键词列表  kidList 参数错误
        ///</summary>
        [Description("关键词列表  kidList 参数错误")]
        _200020_关键词列表KidList参数错误 = 200020,
        ///<summary>
        ///场景描述  sceneDesc 参数错误
        ///</summary>
        [Description("场景描述  sceeDesc 参数错误")]
        _200021_场景描述SceneDesc参数错误 = 200021,
        ///<summary>
        ///禁止创建/更新商品（如商品创建功能被封禁） 或 禁止编辑&amp;更新房间
        ///</summary>
        [Description("禁止创建/更新商品（如商品创建功能被封禁） 或 禁止编辑&amp;更新房间")]
        _300001_禁止创建更新商品如商品创建功能被封禁或禁止编辑Amp更新房间 = 300001,
        ///<summary>
        ///名称长度不符合规则
        ///</summary>
        [Description("名称长度不符合规则")]
        _300002_名称长度不符合规则 = 300002,
        ///<summary>
        ///价格输入不合规（如现价比原价大、传入价格非数字等）
        ///</summary>
        [Description("价格输入不合规（如现价比原价大、传入价格非数字等）")]
        _300003_价格输入不合规如现价比原价大传入价格非数字等 = 300003,
        ///<summary>
        ///商品名称存在违规违法内容
        ///</summary>
        [Description("商品名称存在违规违法内容")]
        _300004_商品名称存在违规违法内容 = 300004,
        ///<summary>
        ///商品图片存在违规违法内容
        ///</summary>
        [Description("商品图片存在违规违法内容")]
        _300005_商品图片存在违规违法内容 = 300005,
        ///<summary>
        ///图片上传失败（如mediaID过期）
        ///</summary>
        [Description("图片上传失败（如mediaID过期）")]
        _300006_图片上传失败如mediaID过期 = 300006,
        ///<summary>
        ///线上小程序版本不存在该链接
        ///</summary>
        [Description("线上小程序版本不存在该链接")]
        _300007_线上小程序版本不存在该链接 = 300007,
        ///<summary>
        ///添加商品失败
        ///</summary>
        [Description("添加商品失败")]
        _300008_添加商品失败 = 300008,
        ///<summary>
        ///商品审核撤回失败
        ///</summary>
        [Description("商品审核撤回失败")]
        _300009_商品审核撤回失败 = 300009,
        ///<summary>
        ///商品审核状态不对（如商品审核中）
        ///</summary>
        [Description("商品审核状态不对（如商品审核中）")]
        _300010_商品审核状态不对如商品审核中 = 300010,
        ///<summary>
        ///操作非法（API不允许操作非API创建的商品）
        ///</summary>
        [Description("操作非法（API不允许操作非API创建的商品）")]
        _300011_操作非法API不允许操作非API创建的商品 = 300011,
        ///<summary>
        ///没有提审额度（每天500次提审额度）
        ///</summary>
        [Description("没有提审额度（每天500次提审额度）")]
        _300012_没有提审额度每天500次提审额度 = 300012,
        ///<summary>
        ///提审失败
        ///</summary>
        [Description("提审失败")]
        _300013_提审失败 = 300013,
        ///<summary>
        ///审核中，无法删除（非零代表失败）
        ///</summary>
        [Description("审核中，无法删除（非零代表失败）")]
        _300014_审核中无法删除非零代表失败 = 300014,
        ///<summary>
        ///商品未提审
        ///</summary>
        [Description("商品未提审")]
        _300017_商品未提审 = 300017,
        ///<summary>
        ///商品添加成功，审核失败
        ///</summary>
        [Description("商品添加成功，审核失败")]
        _300021_商品添加成功审核失败 = 300021,
        ///<summary>
        ///此房间号不存在
        ///</summary>
        [Description("此房间号不存在")]
        _300022_此房间号不存在 = 300022,
        ///<summary>
        ///房间状态 拦截（当前房间状态不允许此操作）
        ///</summary>
        [Description("房间状态 拦截（当前房间状态不允许此操作）")]
        _300023_房间状态拦截当前房间状态不允许此操作 = 300023,
        ///<summary>
        ///商品不存在
        ///</summary>
        [Description("商品不存在")]
        _300024_商品不存在 = 300024,
        ///<summary>
        ///商品审核未通过
        ///</summary>
        [Description("商品审核未通过")]
        _300025_商品审核未通过 = 300025,
        ///<summary>
        ///房间商品数量已经满额
        ///</summary>
        [Description("房间商品数量已经满额")]
        _300026_房间商品数量已经满额 = 300026,
        ///<summary>
        ///导入商品失败
        ///</summary>
        [Description("导入商品失败")]
        _300027_导入商品失败 = 300027,
        ///<summary>
        ///房间名称违规
        ///</summary>
        [Description("房间名称违规")]
        _300028_房间名称违规 = 300028,
        ///<summary>
        ///主播昵称违规
        ///</summary>
        [Description("主播昵称违规")]
        _300029_主播昵称违规 = 300029,
        ///<summary>
        ///主播微信号不合法
        ///</summary>
        [Description("主播微信号不合法")]
        _300030_主播微信号不合法 = 300030,
        ///<summary>
        ///直播间封面图不合规
        ///</summary>
        [Description("直播间封面图不合规")]
        _300031_直播间封面图不合规 = 300031,
        ///<summary>
        ///直播间分享图违规
        ///</summary>
        [Description("直播间分享图违规")]
        _300032_直播间分享图违规 = 300032,
        ///<summary>
        ///添加商品超过直播间上限
        ///</summary>
        [Description("添加商品超过直播间上限")]
        _300033_添加商品超过直播间上限 = 300033,
        ///<summary>
        ///主播微信昵称长度不符合要求
        ///</summary>
        [Description("主播微信昵称长度不符合要求")]
        _300034_主播微信昵称长度不符合要求 = 300034,
        ///<summary>
        ///主播微信号不存在
        ///</summary>
        [Description("主播微信号不存在")]
        _300035_主播微信号不存在 = 300035,
        ///<summary>
        ///主播微信号未实名认证
        ///</summary>
        [Description("主播微信号未实名认证")]
        _300036_主播微信号未实名认证 = 300036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _600001_InvalidFileName = 600001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _600002_NoPermissionToUploadFile = 600002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _600003_InvalidSizeOfSource = 600003,
        ///<summary>
        ///票据已存在
        ///</summary>
        [Description("票据已存在")]
        _928000_票据已存在 = 928000,
        ///<summary>
        ///票据不存在
        ///</summary>
        [Description("票据不存在")]
        _928001_票据不存在 = 928001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930555_SysemError = 930555,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930556_DeliveryTimeout = 930556,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930557_DeliverySystemError = 930557,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930558_DeliveryLogicError = 930558,
        ///<summary>
        ///沙盒环境openid无效
        ///</summary>
        [Description("沙盒环境opeid无效")]
        _930559_InvaildOpenid = 930559,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930560_ShopidNeedBindFirst = 930560,
        ///<summary>
        ///参数错误
        ///</summary>
        [Description("参数错误")]
        _930561_ArgsError = 930561,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930562_OrderAlreadyExists = 930562,
        ///<summary>
        ///订单不存在
        ///</summary>
        [Description("订单不存在")]
        _930563_OrderNotExists = 930563,
        ///<summary>
        ///沙盒环境调用无配额
        ///</summary>
        [Description("沙盒环境调用无配额")]
        _930564_QuotaRunOutTryNextDay = 930564,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930565_OrderFinished = 930565,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930566_NotSupportPlzAuthAtMpWeixinQqCom = 930566,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930567_ShopArgError = 930567,
        ///<summary>
        ///不支持个人类型小程序
        ///</summary>
        [Description("不支持个人类型小程序")]
        _930568_NotPersonalAccount = 930568,
        ///<summary>
        ///已经开通不需要再开通
        ///</summary>
        [Description("已经开通不需要再开通")]
        _930569_AlreadyOpen = 930569,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _930570_CargoFirstClassOrCargoSecondClassInvalid = 930570,
        ///<summary>
        ///该商户没有内测权限，请先申请权限: https://wj.qq.com/s2/7243532/fcfb/
        ///</summary>
        [Description("该商户没有内测权限，请先申请权限: https://wj.qq.com/s2/7243532/fcfb/")]
        _930571_该商户没有内测权限请先申请权限HttpsWjQqComS27243532Fcfb = 930571,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _931010_FeeAlreadySet = 931010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _6000100_UnbindDownloadUrl = 6000100,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _6000101_NoResponseData = 6000101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _6000102_ResponseDataTooBig = 6000102,
        ///<summary>
        ///POST 数据参数不合法
        ///</summary>
        [Description("POST 数据参数不合法")]
        _9001001_POST数据参数不合法 = 9001001,
        ///<summary>
        ///远端服务不可用
        ///</summary>
        [Description("远端服务不可用")]
        _9001002_远端服务不可用 = 9001002,
        ///<summary>
        ///Ticket 不合法
        ///</summary>
        [Description("Ticket 不合法")]
        _9001003_Ticket不合法 = 9001003,
        ///<summary>
        ///获取摇周边用户信息失败
        ///</summary>
        [Description("获取摇周边用户信息失败")]
        _9001004_获取摇周边用户信息失败 = 9001004,
        ///<summary>
        ///获取商户信息失败
        ///</summary>
        [Description("获取商户信息失败")]
        _9001005_获取商户信息失败 = 9001005,
        ///<summary>
        ///获取 OpenID 失败
        ///</summary>
        [Description("获取 OpeID 失败")]
        _9001006_获取OpenID失败 = 9001006,
        ///<summary>
        ///上传文件缺失
        ///</summary>
        [Description("上传文件缺失")]
        _9001007_上传文件缺失 = 9001007,
        ///<summary>
        ///上传素材的文件类型不合法
        ///</summary>
        [Description("上传素材的文件类型不合法")]
        _9001008_上传素材的文件类型不合法 = 9001008,
        ///<summary>
        ///上传素材的文件尺寸不合法
        ///</summary>
        [Description("上传素材的文件尺寸不合法")]
        _9001009_上传素材的文件尺寸不合法 = 9001009,
        ///<summary>
        ///上传失败
        ///</summary>
        [Description("上传失败")]
        _9001010_上传失败 = 9001010,
        ///<summary>
        ///帐号不合法
        ///</summary>
        [Description("帐号不合法")]
        _9001020_帐号不合法 = 9001020,
        ///<summary>
        ///已有设备激活率低于 50% ，不能新增设备
        ///</summary>
        [Description("已有设备激活率低于 50% ，不能新增设备")]
        _9001021_已有设备激活率低于50不能新增设备 = 9001021,
        ///<summary>
        ///设备申请数不合法，必须为大于 0 的数字
        ///</summary>
        [Description("设备申请数不合法，必须为大于 0 的数字")]
        _9001022_设备申请数不合法必须为大于0的数字 = 9001022,
        ///<summary>
        ///已存在审核中的设备 ID 申请
        ///</summary>
        [Description("已存在审核中的设备 ID 申请")]
        _9001023_已存在审核中的设备ID申请 = 9001023,
        ///<summary>
        ///一次查询设备 ID 数量不能超过 50
        ///</summary>
        [Description("一次查询设备 ID 数量不能超过 50")]
        _9001024_一次查询设备ID数量不能超过50 = 9001024,
        ///<summary>
        ///设备 ID 不合法
        ///</summary>
        [Description("设备 ID 不合法")]
        _9001025_设备ID不合法 = 9001025,
        ///<summary>
        ///页面 ID 不合法
        ///</summary>
        [Description("页面 ID 不合法")]
        _9001026_页面ID不合法 = 9001026,
        ///<summary>
        ///页面参数不合法
        ///</summary>
        [Description("页面参数不合法")]
        _9001027_页面参数不合法 = 9001027,
        ///<summary>
        ///一次删除页面 ID 数量不能超过 10
        ///</summary>
        [Description("一次删除页面 ID 数量不能超过 10")]
        _9001028_一次删除页面ID数量不能超过10 = 9001028,
        ///<summary>
        ///页面已应用在设备中，请先解除应用关系再删除
        ///</summary>
        [Description("页面已应用在设备中，请先解除应用关系再删除")]
        _9001029_页面已应用在设备中请先解除应用关系再删除 = 9001029,
        ///<summary>
        ///一次查询页面 ID 数量不能超过 50
        ///</summary>
        [Description("一次查询页面 ID 数量不能超过 50")]
        _9001030_一次查询页面ID数量不能超过50 = 9001030,
        ///<summary>
        ///时间区间不合法
        ///</summary>
        [Description("时间区间不合法")]
        _9001031_时间区间不合法 = 9001031,
        ///<summary>
        ///保存设备与页面的绑定关系参数错误
        ///</summary>
        [Description("保存设备与页面的绑定关系参数错误")]
        _9001032_保存设备与页面的绑定关系参数错误 = 9001032,
        ///<summary>
        ///门店 ID 不合法
        ///</summary>
        [Description("门店 ID 不合法")]
        _9001033_门店ID不合法 = 9001033,
        ///<summary>
        ///设备备注信息过长
        ///</summary>
        [Description("设备备注信息过长")]
        _9001034_设备备注信息过长 = 9001034,
        ///<summary>
        ///设备申请参数不合法
        ///</summary>
        [Description("设备申请参数不合法")]
        _9001035_设备申请参数不合法 = 9001035,
        ///<summary>
        ///查询起始值 begin 不合法
        ///</summary>
        [Description("查询起始值 begi 不合法")]
        _9001036_查询起始值Begin不合法 = 9001036,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002008_ParamsInvalid = 9002008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002009_ShopIdNotExist = 9002009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002010_SsidOrPasswordShouldStartWithWX = 9002010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002011_SsidCanNotIncludeChinese = 9002011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002012_PassswordCanNotIncludeChinese = 9002012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002013_PasswordMustBeBetween8And24Characters = 9002013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002016_DeviceExist = 9002016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002017_DeviceNotExist = 9002017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002026_TheSizeOfQueryListReachLimit = 9002026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002041_NotAllowedToModifyEnsureYouAreAnCertifiedOrComponentAccount = 9002041,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002044_InvalidSsidCanNotIncludeNoneUtf8CharactersAndShouldBeBetween1And32Bytes = 9002044,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9002052_ShopIdHasNotBeAuditedThisBarTypeIsNotEnable = 9002052,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9007003_ProtocolTypeIsNotSameWithTheExistDevice = 9007003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9007004_SsidNotExist = 9007004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9007005_DeviceCountLimit = 9007005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9008001_CardInfoNotExist = 9008001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9008002_CardExpirationTimeIsInvalid = 9008002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9008003_UrlSizeInvalidKeepLessThan255 = 9008003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9008004_UrlCanNotIncludeChinese = 9008004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200001_OrderIdNotExist = 9200001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200002_OrderOfOtherBiz = 9200002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200003_Blocked = 9200003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200211_PaymentNoticeDisabled = 9200211,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200231_PaymentNoticeNotExist = 9200231,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200232_PaymentNoticePaid = 9200232,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200233_PaymentNoticeCanceled = 9200233,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200235_PaymentNoticeExpired = 9200235,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200236_BankNotAllow = 9200236,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200295_FreqLimit = 9200295,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200297_SuspendPaymentAtCurrentTime = 9200297,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200298_3rdRespDecryptError = 9200298,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200299_3rdRespSystemError = 9200299,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9200300_3rdRespSignError = 9200300,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201000_DescEmpty = 9201000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201001_FeeNotEqualItems = 9201001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201002_PaymentInfoIncorrect = 9201002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201003_FeeIs0 = 9201003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201004_PaymentExpireDateFormatError = 9201004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201005_AppidError = 9201005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201006_PaymentOrderIdError = 9201006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201007_OpenidError = 9201007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201008_ReturnUrlError = 9201008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201009_IpError = 9201009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201010_OrderIdError = 9201010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201011_ReasonError = 9201011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201012_MchIdError = 9201012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201013_BillDateError = 9201013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201014_BillTypeError = 9201014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201015_TradeTypeError = 9201015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201016_BankIdError = 9201016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201017_BankAccountError = 9201017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201018_PaymentNoticeNoError = 9201018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201019_DepartmentCodeError = 9201019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201020_PaymentNoticeTypeError = 9201020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201021_RegionCodeError = 9201021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201022_DepartmentNameError = 9201022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201023_FeeNotEqualFinanceS = 9201023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201024_RefundOutIdError = 9201024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201026_NotCombinedOrderId = 9201026,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201027_PartialSubOrderIsTest = 9201027,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201029_DescTooLong = 9201029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201031_SubOrderListSizeError = 9201031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201032_SubOrderRepeated = 9201032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201033_AuthCodeEmpty = 9201033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201034_BankIdEmptyButMchIdNotEmpty = 9201034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9201035_SumOfOtherFeesExceedTotalFee = 9201035,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202000_OtherUserPaying = 9202000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202001_PayProcessNotFinish = 9202001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202002_NoRefundPermission = 9202002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202003_IpLimit = 9202003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202004_FreqLimit = 9202004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202005_UserWeixinAccountAbnormal = 9202005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202006_AccountBalanceNotEnough = 9202006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202010_RefundRequestRepeated = 9202010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202011_HasRefunded = 9202011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202012_RefundExceedTotalFee = 9202012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202013_BusiIdDup = 9202013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202016_NotCheckSign = 9202016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202017_CheckSignFailed = 9202017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202018_SubOrderError = 9202018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202020_OrderStatusError = 9202020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9202021_UnifiedOrderRepeatedly = 9202021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203000_RequestToNotificationUrlFail = 9203000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203001_HttpRequestFail = 9203001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203002_HttpResponseDataError = 9203002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203003_HttpResponseDataRSADecryptFail = 9203003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203004_HttpResponseDataAESDecryptFail = 9203004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9203999_SystemBusyPleaseTryAgainLater = 9203999,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9204000_GetrealnameTokenError = 9204000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9204001_GetrealnameUserOrTokenError = 9204001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9204002_GetrealnameAppidOrTokenError = 9204002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205000_FinanceConfNotExist = 9205000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205001_BankConfNotExist = 9205001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205002_WeiBanJuConfNotExist = 9205002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205010_SymmetricKeyConfNotExist = 9205010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205101_OutOrderIdNotExist = 9205101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9205201_BillNotExist = 9205201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206000_3rdRespPayChannelEmpty = 9206000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206001_3rdRespOrderIdEmpty = 9206001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206002_3rdRespBillTypeCodeEmpty = 9206002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206003_3rdRespBillNoEmpty = 9206003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206200_3rdRespEmpty = 9206200,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206201_3rdRespNotJson = 9206201,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206900_Connect3rdError = 9206900,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206901_Connect3rdTimeout = 9206901,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206910_Read3rdRespError = 9206910,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9206911_Read3rdRespTimeout = 9206911,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207000_BossError = 9207000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207001_WechatPayError = 9207001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207002_BossParamError = 9207002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207003_PayError = 9207003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207004_AuthCodeExpired = 9207004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207005_UserBalanceNotEnough = 9207005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207006_CardNotSupport = 9207006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207007_OrderReversed = 9207007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207008_UserPayingNeedInputPassword = 9207008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207009_AuthCodeError = 9207009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207010_AuthCodeInvalid = 9207010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207011_NotAllowToReverseWhenUserPaying = 9207011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207012_OrderPaid = 9207012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207013_OrderClosed = 9207013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207028_VehicleNotExists = 9207028,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207029_VehicleRequestBlocked = 9207029,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207030_VehicleAuthError = 9207030,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207031_ContractOverLimit = 9207031,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207032_TradeError = 9207032,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207033_TradeTimeInvalid = 9207033,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207034_ChannelTypeInvalid = 9207034,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9207050_ExpireTimeRangeError = 9207050,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9210000_QueryFinanceError = 9210000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291000_OpenidError = 9291000,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291001_OpenidAppidNotMatch = 9291001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291002_AppAppidNotExist = 9291002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291003_AppAppidNotApp = 9291003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291004_AppidEmpty = 9291004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291005_AppidNotMatchAccessToken = 9291005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9291006_InvalidSign = 9291006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9299999_BackendLogicError = 9299999,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300001_BeginTimeCanNotBeforeNow = 9300001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300002_EndTimeCanNotBeforeNow = 9300002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300003_BeginTimeMustLessThanEndTime = 9300003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300004_EndTimeBeginTimeGt1year = 9300004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300005_InvalidMaxParticTimes = 9300005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300006_InvalidActivityStatus = 9300006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300007_GiftNumMustGt0AndLt15 = 9300007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300008_InvalidTinyAppid = 9300008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300009_ActivityCanNotFinish = 9300009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300010_CardInfoListMustGt2 = 9300010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300011_InvalidCardId = 9300011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300012_CardIdMustBelongThisAppid = 9300012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300013_CardIdIsNotSwipeCardOrPayCash = 9300013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300014_SomeCardIdIsOutOfStock = 9300014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300015_SomeCardIdIsInvalidStatus = 9300015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300016_MembershipOrNewOldTinyappUserOnlySupportOne = 9300016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300017_InvalidLogicForMembership = 9300017,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300018_InvalidLogicForTinyappNewOldUser = 9300018,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300019_InvalidActivityType = 9300019,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300020_InvalidActivityId = 9300020,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300021_InvalidHelpMaxTimes = 9300021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300022_InvalidCoverUrl = 9300022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300023_InvalidGenLimit = 9300023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300024_CardSEndTimeCannotEarlyThanActSEndTime = 9300024,
        ///<summary>
        ///快递侧逻辑错误，详细原因需要看 delivery_resultcode, 请先确认一下编码方式，python建议 json.dumps(b, ensure_ascii=False)，php建议 json_encode($arr, JSON_UNESCAPED_UNICODE)
        ///</summary>
        [Description("快递侧逻辑错误，详细原因需要看 delivery_resultcode, 请先确认一下编码方式，pytho建议 jso.dumps(b, esure_ascii=False)，php建议 jso_ecode($arr, JSON_UNESCAPED_UNICODE)")]
        _9300501_DeliverySideError = 9300501,
        ///<summary>
        ///快递公司系统错误
        ///</summary>
        [Description("快递公司系统错误")]
        _9300502_DeliverySideSysError = 9300502,
        ///<summary>
        ///delivery_id 不存在
        ///</summary>
        [Description("delivery_id 不存在")]
        _9300503_SpecifiedDeliveryIdIsNotRegisterred = 9300503,
        ///<summary>
        ///service_type 不存在
        ///</summary>
        [Description("service_type 不存在")]
        _9300504_SpecifiedDeliveryIdHasBeedBanned = 9300504,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300505_ShopBanned = 9300505,
        ///<summary>
        ///运单 ID 已经存在轨迹，不可取消
        ///</summary>
        [Description("运单 ID 已经存在轨迹，不可取消")]
        _9300506_OrderCanTCancel = 9300506,
        ///<summary>
        ///Token 不正确
        ///</summary>
        [Description("Toke 不正确")]
        _9300507_InvalidTokenCanTDecryptionOrDecryptionResultIsDifferentFromThePlaintext = 9300507,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300508_OrderIdHasBeenUsed = 9300508,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300509_SpeedLimitRetryTooFast = 9300509,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300510_InvalidServiceType = 9300510,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300511_InvalidBranchId = 9300511,
        ///<summary>
        ///模板格式错误，渲染失败
        ///</summary>
        [Description("模板格式错误，渲染失败")]
        _9300512_InvalidWaybillTemplateFormat = 9300512,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300513_OutOfQuota = 9300513,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300514_AddNetBranchFailTryUpdateBranchApi = 9300514,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300515_WxaAppidNotExist = 9300515,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300516_WxaAppidAndCurrentBizuinIsNotLinkedOrNotTheSameOwner = 9300516,
        ///<summary>
        ///update_type 不正确,请使用"bind" 或者“unbind”
        ///</summary>
        [Description("update_type 不正确,请使用bid 或者“ubid”")]
        _9300517_InvalidUpdateTypePleaseUseBindOrUnbind = 9300517,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300520_InvalidDeliveryId = 9300520,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300521_TheOrderidIsInOurSystemAndWaybillIsGenerating = 9300521,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300522_ThisOrderidIsRepeated = 9300522,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300523_QuotaIsNotEnoughGoToChargePlease = 9300523,
        ///<summary>
        ///订单已取消（一般为重复取消订单）
        ///</summary>
        [Description("订单已取消（一般为重复取消订单）")]
        _9300524_OrderAlreadyCanceled = 9300524,
        ///<summary>
        ///bizid未绑定
        ///</summary>
        [Description("bizid未绑定")]
        _9300525_BizIdNotBind = 9300525,
        ///<summary>
        ///参数字段长度不正确
        ///</summary>
        [Description("参数字段长度不正确")]
        _9300526_ArgSizeExceedLimit = 9300526,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300527_DeliveryDoesNotSupportQuota = 9300527,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300528_InvalidWaybillId = 9300528,
        ///<summary>
        ///账号已绑定过
        ///</summary>
        [Description("账号已绑定过")]
        _9300529_BizIdAlreadyBinded = 9300529,
        ///<summary>
        ///解绑的biz_id不存在
        ///</summary>
        [Description("解绑的biz_id不存在")]
        _9300530_BizIdIsNotExist = 9300530,
        ///<summary>
        ///bizid无效 或者密码错误
        ///</summary>
        [Description("bizid无效 或者密码错误")]
        _9300531_InvalidBizIdOrPassword = 9300531,
        ///<summary>
        ///绑定已提交，审核中
        ///</summary>
        [Description("绑定已提交，审核中")]
        _9300532_BindSubmitAndIsChecking = 9300532,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300533_InvalidTagidList = 9300533,
        ///<summary>
        ///add_source=2时，wx_appid和当前小程序不同主体
        ///</summary>
        [Description("add_source=2时，wx_appid和当前小程序不同主体")]
        _9300534_InvalidAppidNotSameBody = 9300534,
        ///<summary>
        ///shop字段商品缩略图 url、商品名称为空或者非法，或者商品数量为0
        ///</summary>
        [Description("shop字段商品缩略图 url、商品名称为空或者非法，或者商品数量为0")]
        _9300535_InvalidShopArg = 9300535,
        ///<summary>
        ///add_source=2时，wx_appid无效
        ///</summary>
        [Description("add_source=2时，wx_appid无效")]
        _9300536_InvalidWxaAppid = 9300536,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300537_FreqLimit = 9300537,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300538_InputTaskEmpty = 9300538,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300539_TooManyTask = 9300539,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300540_TaskNotExist = 9300540,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300541_DeliveryCallbackError = 9300541,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300601_IdCardNoIsInvalid = 9300601,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300602_NameIsInvalid = 9300602,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300603_PlateNoIsInvalid = 9300603,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300604_AuthKeyDecodeError = 9300604,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300605_AuthKeyIsExpired = 9300605,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300606_AuthKeyAndAppinfoNotMatch = 9300606,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300607_UserNotConfirm = 9300607,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300608_UserConfirmIsExpired = 9300608,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300609_ApiExceedLimit = 9300609,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300610_CarLicenseInfoIsInvalid = 9300610,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300611_VarificationTypeNotSupport = 9300611,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300701_InputParamError = 9300701,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300702_ThisCodeHasBeenUsed = 9300702,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300703_InvalidDate = 9300703,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300704_NotCurrentlyAvailable = 9300704,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300705_CodeNotExistOrExpired = 9300705,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300706_CodeNotExistOrExpired = 9300706,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300707_WxpayError = 9300707,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9300708_WxpayOverlimit = 9300708,
        ///<summary>
        ///无效的微信号
        ///</summary>
        [Description("无效的微信号")]
        _9300801_无效的微信号 = 9300801,
        ///<summary>
        ///服务号未开通导购功能
        ///</summary>
        [Description("服务号未开通导购功能")]
        _9300802_服务号未开通导购功能 = 9300802,
        ///<summary>
        ///微信号已经绑定为导购
        ///</summary>
        [Description("微信号已经绑定为导购")]
        _9300803_微信号已经绑定为导购 = 9300803,
        ///<summary>
        ///该微信号不是导购
        ///</summary>
        [Description("该微信号不是导购")]
        _9300804_该微信号不是导购 = 9300804,
        ///<summary>
        ///微信号已经被其他账号绑定为导购
        ///</summary>
        [Description("微信号已经被其他账号绑定为导购")]
        _9300805_微信号已经被其他账号绑定为导购 = 9300805,
        ///<summary>
        ///粉丝和导购不存在绑定关系
        ///</summary>
        [Description("粉丝和导购不存在绑定关系")]
        _9300806_粉丝和导购不存在绑定关系 = 9300806,
        ///<summary>
        ///标签值无效，不是可选标签值
        ///</summary>
        [Description("标签值无效，不是可选标签值")]
        _9300807_标签值无效不是可选标签值 = 9300807,
        ///<summary>
        ///标签值不存在
        ///</summary>
        [Description("标签值不存在")]
        _9300808_标签值不存在 = 9300808,
        ///<summary>
        ///展示标签值不存在
        ///</summary>
        [Description("展示标签值不存在")]
        _9300809_展示标签值不存在 = 9300809,
        ///<summary>
        ///导购昵称太长，最多16个字符
        ///</summary>
        [Description("导购昵称太长，最多16个字符")]
        _9300810_导购昵称太长最多16个字符 = 9300810,
        ///<summary>
        ///只支持mmbiz.qpic.cn域名的图片
        ///</summary>
        [Description("只支持mmbiz.qpic.c域名的图片")]
        _9300811_只支持mmbizQpicCn域名的图片 = 9300811,
        ///<summary>
        ///达到导购绑定个数限制
        ///</summary>
        [Description("达到导购绑定个数限制")]
        _9300812_达到导购绑定个数限制 = 9300812,
        ///<summary>
        ///达到导购粉丝绑定个数限制
        ///</summary>
        [Description("达到导购粉丝绑定个数限制")]
        _9300813_达到导购粉丝绑定个数限制 = 9300813,
        ///<summary>
        ///敏感词个数超过上限
        ///</summary>
        [Description("敏感词个数超过上限")]
        _9300814_敏感词个数超过上限 = 9300814,
        ///<summary>
        ///快捷回复个数超过上限
        ///</summary>
        [Description("快捷回复个数超过上限")]
        _9300815_快捷回复个数超过上限 = 9300815,
        ///<summary>
        ///文字素材个数超过上限
        ///</summary>
        [Description("文字素材个数超过上限")]
        _9300816_文字素材个数超过上限 = 9300816,
        ///<summary>
        ///小程序卡片素材个数超过上限
        ///</summary>
        [Description("小程序卡片素材个数超过上限")]
        _9300817_小程序卡片素材个数超过上限 = 9300817,
        ///<summary>
        ///图片素材个数超过上限
        ///</summary>
        [Description("图片素材个数超过上限")]
        _9300818_图片素材个数超过上限 = 9300818,
        ///<summary>
        ///mediaid 有误
        ///</summary>
        [Description("mediaid 有误")]
        _9300819_Mediaid有误 = 9300819,
        ///<summary>
        ///可查询标签类别超过上限
        ///</summary>
        [Description("可查询标签类别超过上限")]
        _9300820_可查询标签类别超过上限 = 9300820,
        ///<summary>
        ///小程序卡片内appid不符合要求
        ///</summary>
        [Description("小程序卡片内appid不符合要求")]
        _9300821_小程序卡片内appid不符合要求 = 9300821,
        ///<summary>
        ///标签类别的名字无效
        ///</summary>
        [Description("标签类别的名字无效")]
        _9300822_标签类别的名字无效 = 9300822,
        ///<summary>
        ///查询聊天记录时间参数有误
        ///</summary>
        [Description("查询聊天记录时间参数有误")]
        _9300823_查询聊天记录时间参数有误 = 9300823,
        ///<summary>
        ///自动回复字数太长
        ///</summary>
        [Description("自动回复字数太长")]
        _9300824_自动回复字数太长 = 9300824,
        ///<summary>
        ///导购群组id错误
        ///</summary>
        [Description("导购群组id错误")]
        _9300825_导购群组id错误 = 9300825,
        ///<summary>
        ///维护中
        ///</summary>
        [Description("维护中")]
        _9300826_维护中 = 9300826,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301001_InvalidParameter = 9301001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301002_CallApiServiceFailed = 9301002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301003_InternalException = 9301003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301004_SaveDataError = 9301004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301006_InvalidAppid = 9301006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301007_InvalidApiConfig = 9301007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301008_InvalidApiInfo = 9301008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301009_AddResultCheckFailed = 9301009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301010_ConsumptionFailure = 9301010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301011_FrequencyLimitReached = 9301011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9301012_ServiceTimeout = 9301012,
        ///<summary>
        ///该开发小程序已开通小程序直播权限，不支持发布版本。如需发版，请解绑开发小程序后再操作。
        ///</summary>
        [Description("该开发小程序已开通小程序直播权限，不支持发布版本。如需发版，请解绑开发小程序后再操作。")]
        _9400001_该开发小程序已开通小程序直播权限不支持发布版本如需发版请解绑开发小程序后再操作 = 9400001,
        ///<summary>
        ///商品已存在
        ///</summary>
        [Description("商品已存在")]
        _9401001_商品已存在 = 9401001,
        ///<summary>
        ///商品不存在
        ///</summary>
        [Description("商品不存在")]
        _9401002_商品不存在 = 9401002,
        ///<summary>
        ///类目已存在
        ///</summary>
        [Description("类目已存在")]
        _9401003_类目已存在 = 9401003,
        ///<summary>
        ///类目不存在
        ///</summary>
        [Description("类目不存在")]
        _9401004_类目不存在 = 9401004,
        ///<summary>
        ///SKU已存在
        ///</summary>
        [Description("SKU已存在")]
        _9401005_SKU已存在 = 9401005,
        ///<summary>
        ///SKU不存在
        ///</summary>
        [Description("SKU不存在")]
        _9401006_SKU不存在 = 9401006,
        ///<summary>
        ///属性已存在
        ///</summary>
        [Description("属性已存在")]
        _9401007_属性已存在 = 9401007,
        ///<summary>
        ///属性不存在
        ///</summary>
        [Description("属性不存在")]
        _9401008_属性不存在 = 9401008,
        ///<summary>
        ///非法参数
        ///</summary>
        [Description("非法参数")]
        _9401020_非法参数 = 9401020,
        ///<summary>
        ///没有商品权限
        ///</summary>
        [Description("没有商品权限")]
        _9401021_没有商品权限 = 9401021,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9401022_SPUNOTALLOW = 9401022,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9401023_SPUNOTALLOWEDIT = 9401023,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9401024_SKUNOTALLOW = 9401024,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9401025_SKUNOTALLOWEDIT = 9401025,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402001_LimitTooLarge = 9402001,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402002_SingleSendBeenBlocked = 9402002,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402003_AllSendBeenBlocked = 9402003,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402004_InvalidMsgId = 9402004,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402005_SendMsgTooQuick = 9402005,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402006_SendToSingleUserTooQuick = 9402006,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402007_SendToAllUserTooQuick = 9402007,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402008_SendTypeError = 9402008,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402009_CanNotSendThisMsg = 9402009,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402010_ContentTooLongOrNoContent = 9402010,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402011_PathNotExist = 9402011,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402012_ContainEvilWord = 9402012,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402013_PathNeedHtmlSuffix = 9402013,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402014_NotOpenToPersonalBodyType = 9402014,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402015_NotOpenToViolationBodyType = 9402015,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402016_NotOpenToLowQualityProvider = 9402016,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402101_InvalidProductId = 9402101,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402102_DeviceIdCountMoreThanLimit = 9402102,
        ///<summary>
        ///请勿频繁提交，待上一次操作完成后再提交
        ///</summary>
        [Description("请勿频繁提交，待上一次操作完成后再提交")]
        _9402202_ConcurrentLimit = 9402202,
        ///<summary>
        ///
        ///</summary>
        [Description("")]
        _9402301_UserNotBookThisAdId = 9402301,
        ///<summary>
        ///消息类型错误!
        ///</summary>
        [Description("消息类型错误!")]
        _9403000_消息类型错误 = 9403000,
        ///<summary>
        ///消息字段的内容过长!
        ///</summary>
        [Description("消息字段的内容过长!")]
        _9403001_消息字段的内容过长 = 9403001,
        ///<summary>
        ///消息字段的内容违规!
        ///</summary>
        [Description("消息字段的内容违规!")]
        _9403002_消息字段的内容违规 = 9403002,
        ///<summary>
        ///发送的微信号太多!
        ///</summary>
        [Description("发送的微信号太多!")]
        _9403003_发送的微信号太多 = 9403003,
        ///<summary>
        ///存在错误的微信号!
        ///</summary>
        [Description("存在错误的微信号!")]
        _9403004_存在错误的微信号 = 9403004,
        ///<summary>
        ///直播间列表为空
        ///</summary>
        [Description("直播间列表为空")]
        _9410000_LiveRoomNotExsits = 9410000,
        ///<summary>
        ///获取房间失败
        ///</summary>
        [Description("获取房间失败")]
        _9410001_InnerErrorGetRoomFail = 9410001,
        ///<summary>
        ///获取商品失败
        ///</summary>
        [Description("获取商品失败")]
        _9410002_InnerErrorGetGoodsFail = 9410002,
        ///<summary>
        ///获取回放失败
        ///</summary>
        [Description("获取回放失败")]
        _9410003_InnerErrorGetReplayUrlFail = 9410003,
    }
}
