#pragma checksum "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e188250bfa882e4bbe35c5829551ca7cf433793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SExamIndex_StartExam4), @"mvc.1.0.view", @"/Views/SExamIndex/StartExam4.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\_ViewImports.cshtml"
using ISpanSTA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\_ViewImports.cshtml"
using ISpanSTA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e188250bfa882e4bbe35c5829551ca7cf433793", @"/Views/SExamIndex/StartExam4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69998c8599af2eb48f9d385e2706b13e7e5975ad", @"/Views/_ViewImports.cshtml")]
    public class Views_SExamIndex_StartExam4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ISpanSTA.ViewModel.CStartExam2ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StartExam4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
  
    ViewData["Title"] = "StartExam4";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container mt-5\">\r\n    <h1>StartExam4 ");
#nullable restore
#line 7 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
              Write(Model.examp[0].FName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <h4>CStartExam2ViewModel</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e188250bfa882e4bbe35c5829551ca7cf4337934869", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e188250bfa882e4bbe35c5829551ca7cf4337935143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 14 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
#nullable restore
#line 15 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
           Write(Model.subject[2].FQuestion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 16 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
           Write(Model.examp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                <div id=\"wrapper\">\r\n");
                WriteLiteral("                    <div class=\"container-fluid mt-3\">\r\n                        <div class=\"row\">\r\n");
                WriteLiteral("                            <div class=\"col-md-9 col-sm-7\">\r\n");
#nullable restore
#line 25 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                   for (int i = 0; i < @Model.subject.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div id=""single-choice"">
                                            <div class=""card mb-3"">
                                                <div class=""card-body"">
                                                    <div class=""row"">
                                                        <div class=""col-md-1"">
                                                            <div class=""row"">
                                                                <a class=""font-weight-bold"">Q1：</a>
");
                WriteLiteral("                                                            </div>\r\n                                                            <div class=\"row\">\r\n");
                WriteLiteral(@"                                                            </div>
                                                        </div>

                                                        <div class=""col-md-11"">
                                                            <div id=""text"" class=""row"">
                                                                題目題目題目？");
#nullable restore
#line 43 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                  Write(Model.subject[i].FQuestion);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </div>
                                                            <br />
                                                            <div id=""pic"" class=""row"">

                                                            </div>
                                                            <div id=""option"">
                                                                <div class=""form-check"">
                                                                    <input class=""form-check-input"" type=""radio"" name=""exampleRadios""
                                                                           id=""exampleRadios1"" value=""option1"" checked>
                                                                    <label class=""form-check-label"" for=""exampleRadios1"">
                                                                        A: Options1 ");
#nullable restore
#line 54 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                               Write(Model.subject[i].FOption1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                    </label>
                                                                </div>
                                                                <div class=""form-check"">
                                                                    <input class=""form-check-input"" type=""radio"" name=""exampleRadios""
                                                                           id=""exampleRadios2"" value=""option2"">
                                                                    <label class=""form-check-label"" for=""exampleRadios2"">
                                                                        B: Options2 ");
#nullable restore
#line 61 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                               Write(Model.subject[i].FOption2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                    </label>
                                                                </div>
                                                                <div class=""form-check"">
                                                                    <input class=""form-check-input"" type=""radio"" name=""exampleRadios""
                                                                           id=""exampleRadios1"" value=""option3"" checked>
                                                                    <label class=""form-check-label"" for=""exampleRadios1"">
                                                                        C: Options3 ");
#nullable restore
#line 68 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                               Write(Model.subject[i].FOption3);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                    </label>
                                                                </div>
                                                                <div class=""form-check"">
                                                                    <input class=""form-check-input"" type=""radio"" name=""exampleRadios""
                                                                           id=""exampleRadios1"" value=""option4"" checked>
                                                                    <label class=""form-check-label"" for=""exampleRadios1"">
                                                                        D: Options4 ");
#nullable restore
#line 75 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                               Write(Model.subject[i].FOption4);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                    </label>
                                                                </div>
                                                            </div>
                                                            <hr />
                                                        </div>


                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 87 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <footer class=""sticky-footer bg-white"">
                                    <div class=""container my-auto"">
                                        <div class=""copyright text-center my-auto"">
                                            <button class=""bnt btn-success"">上一題</button>  <button class=""bnt btn-success"">下一題</button>
                                        </div>
                                    </div>
                                </footer>
                            </div>
                            <!-- 試卷面板结束
                            <!-- 進度和試卷訊息面板開始,懸浮面板-->
                            <div style=""position:fixed;top:20px;right:5px"" class=""col-md-3 col-sm-5"">
                                <div class=""navbar navbar-inverse navbar-fixed-top"">
                                    <div class=""navbar-inner"">
");
                WriteLiteral(@"                                        <div class=""container-fluid"">
                                            <div class=""card"">
                                                <div class=""card-header"">

                                                </div>
                                                <div class=""card-body"">

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- 訊息部分開始 -->
                                <div class=""card shadow-sm mb-3"">
                                    <div class=""card-header"">
                                        <a class=""h6 font-weight-bold text-gray-700"">試卷資訊</a>
                                    </div>
                                    <div class=""card-body"">
                                        <br />
              ");
                WriteLiteral("                          <p class=\"h6  text-gray-700\">姓名: 小蘋果 ");
#nullable restore
#line 122 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                        Write(Model.student[0].FStudentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        <p class=\"h6  text-gray-700\">科目: C##### </p>\r\n                                        <p class=\"h6  text-gray-700\">試卷: Test1 ");
#nullable restore
#line 124 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
                                                                          Write(Model.examp[0].FName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <!-- 訊息部分结束 -->
                                <!-- 計時部分开始 -->
                                <div class=""card shadow-sm mb-3"">
                                    <div class=""card-body"">
                                        <br /><br />
                                        剩餘時間:
                                        <br />
                                        <div id=""clockdiv"">
                                            <h1 style=""color: red"">
                                                <div class=""minutes"" style=""float: left""> </div>
                                                <p style=""float: left; color: red; font-size: large; font-weight: bold"">:</p>
                                                <div class=""seconds""></div>
                                            </h1>
                                        </div>

                          ");
                WriteLiteral(@"          </div>
                                </div>
                                <!-- 計時部分结束 -->
                                <div class=""card shadow-sm mb-md-3"">
                                    <div class=""card-header"">
                                        <a class=""h6 font-weight-bold text-gray-700"">答題卡</a>
                                    </div>
                                    <div class=""card-body"">

                                        <hr />
                                        <!-- 答題卡開始 -->
                                        <div class=""row align-middle"">
                                            <div class=""col-md-2 col-sm-4 mb-2"">
                                                <!-- 超連結跳轉题目 -->
                                                <a href=""#"" class=""btn-sm btn-primary btn-circle"">
                                                    1
                                                </a>
                                            </div>");
                WriteLiteral(@"
                                            <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary btn-circle"">
                                                    2
                                                </a>
                                            </div>
                                            <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary btn-circle"">
                                                    3
                                                </a>
                                            </div>
                                            <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary btn-circle"">
                                                    4
                                                </a>
                                            </div>
        ");
                WriteLiteral(@"                                    <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary-outline btn-circle"">
                                                    5
                                                </a>
                                            </div>
                                            <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary-outline btn-circle"">
                                                    6
                                                </a>
                                            </div>
                                            <div class=""col-md-2 col-sm-4"">
                                                <a href=""#"" class=""btn-sm btn-primary-outline btn-circle"">
                                                    7
                                                </a>
                                            </");
                WriteLiteral(@"div>

                                        </div>

                                    </div>
                                </div>
                                <!-- 答題卡结束 -->
                                <br /> <br /> <br />
                                <!-- 交卷部分開始 -->
                                <button class=""btn btn-primary btn-block"">提交</button>
                                <!-- 交卷部分结束 -->
                            </div>
                            <!-- 面板结束-->
                        </div>
                    </div>
                </div>



                <div class=""form-group"">
                    <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    function getTimeRemaining(endtime) {
        var t = Date.parse(endtime) - Date.parse(new Date());
        var seconds = Math.floor((t / 1000) % 60);
        var minutes = Math.floor((t / 1000 / 60) % 1);

        return {
            'total': t,
            'minutes': minutes,
            'seconds': seconds
        };
    }

    function initializeClock(id, endtime) {
        var clock = document.getElementById(id);

        var minutesSpan = clock.querySelector('.minutes');
        var secondsSpan = clock.querySelector('.seconds');

        function updateClock() {
            var t = getTimeRemaining(endtime);


            minutesSpan.innerHTML = ('0' + t.minutes).slice(-2);
            secondsSpan.innerHTML = ('0' + t.seconds).slice(-2);

            if (t.total <= 0) {
                clearInterval(timeinterval);


            }
        }

        updateClock();
        var timeinterval = setInterval(updateClock, 1000);
    }

    var deadline = ne");
                WriteLiteral(@"w Date(Date.parse(new Date()) + 60 * 60 * 1000);
    initializeClock('clockdiv', deadline);

    // ...................................
    var _second = 1000;
    var _minute = _second * 60;
    var _hour = _minute * 60;
    var _day = _hour * 24;
    var timer;
    var end = new Date().getTime() + (60 * _second);
    //

    function showRemaining() {
        var now = new Date();
        var distance = end - now;
        if (distance < 0) {

            clearInterval(timer);
            document.getElementById('countdown').innerHTML = 'EXPIRED!';

            return;
        }
        var days = Math.floor(distance / _day);
        var hours = Math.floor((distance % _day) / _hour);
        var minutes = Math.floor((distance % _hour) / _minute);
        var seconds = Math.floor((distance % _minute) / _second);

        document.getElementById('countdown').innerHTML = days + 'days ';
        document.getElementById('countdown').innerHTML += hours + 'hrs ';
        document.getEle");
                WriteLiteral("mentById(\'countdown\').innerHTML += minutes + \'mins \';\r\n        document.getElementById(\'countdown\').innerHTML += seconds + \'secs\';\r\n    }\r\n\r\n    timer = setInterval(showRemaining, 1000);\r\n    </script>\r\n");
#nullable restore
#line 289 "E:\專題製作第二組-5\IsapnSTA core-20220413T062834Z-001\IsapnSTA core\ISpanSTA\Views\SExamIndex\StartExam4.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ISpanSTA.ViewModel.CStartExam2ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
