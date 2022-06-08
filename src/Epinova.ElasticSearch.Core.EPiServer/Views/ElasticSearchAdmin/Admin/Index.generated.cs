﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Epinova.ElasticSearch.Core.EPiServer.Extensions;
    using Epinova.ElasticSearch.Core.Models.Admin;
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.Editor;
    using EPiServer.Framework.Localization;
    using EPiServer.Security;
    using EPiServer.SpecializedProperties;
    using EPiServer.Web;
    using EPiServer.Web.Mvc.Html;
    using EPiServer.Web.Routing;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ElasticSearchAdmin/Admin/Index.cshtml")]
    public partial class _Views_ElasticSearchAdmin_Admin_Index_cshtml : System.Web.Mvc.WebViewPage<Epinova.ElasticSearch.Core.EPiServer.Models.ViewModels.AdminViewModel>
    {

#line default
#line hidden
public System.Web.WebPages.HelperResult ClusterString(string key)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {
 
    
WriteTo(__razor_helper_writer, Html.Raw(LocalizationService.Current.GetString("/epinovaelasticsearch/clusterhealth/" + key)));

                                                                                                  

});

#line default
#line hidden
}
#line default
#line hidden

#line default
#line hidden
public System.Web.WebPages.HelperResult NodeString(string key)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {
 
    
WriteTo(__razor_helper_writer, Html.Raw(LocalizationService.Current.GetString("/epinovaelasticsearch/node/" + key)));

                                                                                         

});

#line default
#line hidden
}
#line default
#line hidden

#line default
#line hidden
public System.Web.WebPages.HelperResult IndexString(string key)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {
 
    
WriteTo(__razor_helper_writer, Html.Raw(LocalizationService.Current.GetString("/epinovaelasticsearch/indexes/" + key)));

                                                                                            

});

#line default
#line hidden
}
#line default
#line hidden

        public _Views_ElasticSearchAdmin_Admin_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

  
    Layout = "~/Views/ElasticSearchAdmin/_ElasticSearch.cshtml";

WriteLiteral("\r\n\r\n");

DefineSection("Styles", () => {

WriteLiteral(@"
    <style>
        #clusterGrid .field-status,
        #indexGrid .field-health {
            width: 52px;
            text-align: center;
        }

            #clusterGrid .field-status span,
            #indexGrid .field-health span {
                font-size: 32px;
                line-height: 10px;
            }

        #indexGrid .field-status {
            text-transform: capitalize;
        }

        #indexGrid .field-status,
        #indexGrid .field-pri,
        #indexGrid .field-rep {
            width: 70px;
        }

        #indexGrid .field-tokenizer {
            width: 120px;
        }

        #indexGrid .field-actions {
            text-align: center;
            width: 90px;
        }

        #indexGrid .field-storesize {
            width: 100px;
        }

        #indexGrid .field-docscount {
            width: 170px;
        }

        .create-indices-buttons {
            display: flex;
            align-items: center;
            margin-bottom: 10px;
        }

        .create-indices-buttons .button-success .dijitButtonNode {
            background-color: #81c784;
        }

        .create-indices-buttons p {
            margin: 0;
        }
    </style>
");

});

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

  
    if (Model == null)
    {
        return;
    }

    string localizationPath = "/epinovaelasticsearch/indexes/";
    string controllerName = ViewContext.RouteData.Values["controller"] as string ?? "ElasticAdmin";

WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"epi-padding-small\"");

WriteLiteral(">\r\n\r\n    <h1>");

   Write(Html.TranslateWithPath("addorupdateindexes", localizationPath));

WriteLiteral("</h1>\r\n    <div");

WriteLiteral(" class=\"create-indices-buttons\"");

WriteLiteral(">\r\n");

        
         using (Html.BeginForm("AddNewIndex", controllerName))
        {

WriteLiteral("            <button");

WriteLiteral(" data-dojo-type=\"dijit/form/Button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"epi-primary\"");

WriteLiteral(">");

                                                                                    Write(IndexString("addorupdateindexesbutton"));

WriteLiteral("</button>\r\n");

        }

WriteLiteral("        ");

         using (Html.BeginForm("AddNewIndexWithMappings", controllerName))
        {

WriteLiteral("            <button");

WriteLiteral(" data-dojo-type=\"dijit/form/Button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"epi-primary button-success\"");

WriteLiteral(">");

                                                                                                   Write(IndexString("addorupdateindexesmappingbutton"));

WriteLiteral("</button>\r\n");

        }

WriteLiteral("        <p>");

      Write(IndexString("addnewindexinfo"));

WriteLiteral("</p>\r\n    </div>\r\n\r\n");

    
     if (Model.AllIndexes.Any())
    {

WriteLiteral("        <div>\r\n");

            
             using (Html.BeginForm("RunIndexJob", controllerName))
            {

WriteLiteral("                <button");

WriteLiteral(" data-dojo-type=\"dijit/form/Button\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

                                                                    Write(IndexString("runindexjob"));

WriteLiteral("</button>\r\n");

            }

WriteLiteral("        </div>\r\n");

    }

WriteLiteral("\r\n");

    
     if (Model.ClusterHealth != null)
    {

WriteLiteral("        <h1>");

       Write(ClusterString("heading"));

WriteLiteral("</h1>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"clusterGrid\"");

WriteLiteral("></div>\r\n");

WriteLiteral("        <br />");

WriteLiteral("<br />\r\n");

    }

WriteLiteral("\r\n");

    
     if (Model.NodeInfo != null)
    {

WriteLiteral("        <h1>");

       Write(NodeString("heading"));

WriteLiteral("</h1>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"nodeGrid\"");

WriteLiteral("></div>\r\n");

WriteLiteral("        <br />");

WriteLiteral("<br />\r\n");

    }

WriteLiteral("\r\n    <h1>");

   Write(IndexString("heading"));

WriteLiteral("</h1>\r\n    <div");

WriteLiteral(" id=\"indexGrid\"");

WriteLiteral("></div>\r\n\r\n");

    
     if (Model.AllIndexes.Any())
    {
        using (Html.BeginForm("DeleteAll", controllerName))
        {

WriteLiteral("            <div");

WriteLiteral(" class=\"epi-paddingVertical-small epi-alignRight\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" data-dojo-type=\"dijit/form/Button\"");

WriteLiteral("\r\n                        type=\"submit\"");

WriteLiteral("\r\n                        class=\"epi-danger\"");

WriteAttribute("onclick", Tuple.Create("\r\n                        onclick=\"", 3982), Tuple.Create("\"", 4068)
, Tuple.Create(Tuple.Create("", 4017), Tuple.Create("return", 4017), true)
, Tuple.Create(Tuple.Create(" ", 4023), Tuple.Create("confirm(\'", 4024), true)
, Tuple.Create(Tuple.Create("", 4033), Tuple.Create<System.Object, System.Int32>(IndexString("confirmDeleteAll")
, 4033), false)
, Tuple.Create(Tuple.Create("", 4065), Tuple.Create("\');", 4065), true)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

               Write(IndexString("deleteAll"));

WriteLiteral("\r\n                </button>\r\n            </div>\r\n");

        }
    }

WriteLiteral(@"
    <br /><br />
</div>

<script>
    require([
        ""dojo/_base/declare"",
        ""dgrid/Grid"",
        ""dijit/form/Button"",
        ""dijit/form/Select"",
        ""dojo/domReady!""
    ], function (
        declare,
        Grid,
        Button,
        Select
    ) {

        // Cluster
        var clusterData = [
            {
                cluster: '");

                     Write(Model.ClusterHealth.Cluster);

WriteLiteral("\',\r\n                status: \'");

                    Write(Model.ClusterHealth.StatusColor);

WriteLiteral("\',\r\n                timestamp: \'");

                       Write(Model.ClusterHealth.Timestamp);

WriteLiteral("\',\r\n                nodetotal: \'");

                       Write(Model.ClusterHealth.NodeTotal);

WriteLiteral("\',\r\n                nodedata: \'");

                      Write(Model.ClusterHealth.NodeData);

WriteLiteral("\',\r\n                shards: \'");

                    Write(Model.ClusterHealth.Shards);

WriteLiteral("\',\r\n                pri: \'");

                 Write(Model.ClusterHealth.Pri);

WriteLiteral("\',\r\n                relo: \'");

                  Write(Model.ClusterHealth.Relo);

WriteLiteral("\',\r\n                ini: \'");

                 Write(Model.ClusterHealth.Init);

WriteLiteral("\',\r\n                unassign: \'");

                      Write(Model.ClusterHealth.Unassign);

WriteLiteral("\'\r\n            }\r\n        ];\r\n\r\n        var clusterCols = {\r\n            cluster:" +
" \"");

                 Write(ClusterString("cluster"));

WriteLiteral("\",\r\n            status: {\r\n                label: \"");

                   Write(IndexString("status"));

WriteLiteral("\",\r\n                renderCell: function (object, value, node) {\r\n               " +
"     node.innerHTML = \"<span style=\'color: \" + value + \"\'>&bull;</span>\";\r\n     " +
"           }\r\n            },\r\n            timestamp: \"");

                   Write(ClusterString("timestamp"));

WriteLiteral("\",\r\n            nodetotal: \"");

                   Write(ClusterString("nodetotal"));

WriteLiteral("\",\r\n            nodedata: \"");

                  Write(ClusterString("nodedata"));

WriteLiteral("\",\r\n            shards: \"");

                Write(ClusterString("shards"));

WriteLiteral("\",\r\n            pri: \"");

             Write(ClusterString("pri"));

WriteLiteral("\",\r\n            relo: \"");

              Write(ClusterString("relo"));

WriteLiteral("\",\r\n            ini: \"");

             Write(ClusterString("init"));

WriteLiteral("\",\r\n            unassign: \"");

                  Write(ClusterString("unassign"));

WriteLiteral(@"""
        };

        var clusterGrid = new Grid({
            ""class"": ""epi-grid-height--auto epi-grid--with-border"",
            columns: clusterCols
        }, ""clusterGrid"");
        clusterGrid.renderArray(clusterData);


        // Nodes
        var nodeData = [

");

            
             foreach (Node node in Model.NodeInfo)
            {

WriteLiteral("                ");

WriteLiteral("\r\n                {\r\n                    name: \"");

                      Write(node.Name);

WriteLiteral("\",\r\n                    master: \"");

                        Write(NodeString("master" + node.Master));

WriteLiteral("\",\r\n                    version: \"");

                         Write(node.Version);

WriteLiteral("\",\r\n                    ip: \"");

                    Write(node.Ip);

WriteLiteral("\",\r\n                    hdd: \"");

                     Write(node.HddAvailable);

WriteLiteral("\",\r\n                    mem: \"");

                     Write(node.MemoryCurrent);

WriteLiteral(" / ");

                                           Write(node.MemoryTotal);

WriteLiteral("\",\r\n                    uptime: \"");

                        Write(node.Uptime);

WriteLiteral("\"\r\n                }\r\n                ");

WriteLiteral("\r\n");

                
            Write(node == Model.NodeInfo.Last() ? "" : ",");

                                                           
            }

WriteLiteral("        ];\r\n\r\n        var nodeCols = {\r\n            name: \"");

              Write(NodeString("name"));

WriteLiteral("\",\r\n            master: \"");

                Write(NodeString("master"));

WriteLiteral("\",\r\n            version: \"");

                 Write(NodeString("version"));

WriteLiteral("\",\r\n            ip: \"");

            Write(NodeString("ip"));

WriteLiteral("\",\r\n            hdd: \"");

             Write(NodeString("hdd"));

WriteLiteral("\",\r\n            mem: \"");

             Write(NodeString("mem"));

WriteLiteral("\",\r\n            uptime: \"");

                Write(NodeString("uptime"));

WriteLiteral(@"""
        };

        var nodeGrid = new Grid({
            ""class"": ""epi-grid-height--auto epi-grid--with-border"",
            columns: nodeCols
        }, ""nodeGrid"");
        nodeGrid.renderArray(nodeData);


        // Indices
        var indexData = [
");

            
             foreach (IndexInformation index in Model.AllIndexes)
            {

WriteLiteral("                ");

WriteLiteral("\r\n                {\r\n                    index:     \"");

                           Write(Html.Raw(index.Index));

WriteLiteral("\",\r\n                    display:   \"");

                           Write(index.DisplayName);

WriteLiteral("\",\r\n                    health:    \"");

                           Write(index.HealthColor);

WriteLiteral("\",\r\n                    status:    \"");

                           Write(index.Status);

WriteLiteral("\",\r\n                    type:      \"");

                           Write(index.TypeName);

WriteLiteral("\",\r\n                    docscount: \"");

                           Write(index.DocsCount);

WriteLiteral(" / ");

                                              Write(index.DocsDeleted);

WriteLiteral("\",\r\n                    storesize: \"");

                           Write(index.StoreSize);

WriteLiteral("\",\r\n                    tokenizer: \"");

                           Write(index.Tokenizer);

WriteLiteral("\"\r\n                }\r\n                ");

WriteLiteral("\r\n");

                
            Write(index == Model.AllIndexes.Last() ? "" : ",");

                                                              
            }

WriteLiteral("        ];\r\n\r\n        var indexCols = {\r\n            index: \"");

               Write(IndexString("Index"));

WriteLiteral("\",\r\n            display: \"");

                 Write(IndexString("displayName"));

WriteLiteral("\",\r\n            health: {\r\n                label: \"");

                   Write(IndexString("Health"));

WriteLiteral("\",\r\n                renderCell: function (object, value, node) {\r\n               " +
"     node.innerHTML = \"<span style=\'color: \" + value + \"\'>&bull;</span>\";\r\n     " +
"           }\r\n            },\r\n            status: \"");

                Write(IndexString("status"));

WriteLiteral("\",\r\n            type: \"");

              Write(IndexString("type"));

WriteLiteral("\",\r\n            docscount: \"");

                   Write(IndexString("docscount"));

WriteLiteral(" / ");

                                               Write(IndexString("docsdeleted"));

WriteLiteral("\",\r\n            storesize: \"");

                   Write(IndexString("storesize"));

WriteLiteral("\",\r\n            tokenizer: {\r\n                label: \"");

                   Write(IndexString("tokenizer"));

WriteLiteral(@""",
                renderCell: function (object, value, node) {
                    var select = new Select({
                        name: ""tokenizer"",
                        style: { width: '100px' },
                        options: [
                            { label: """);

                                 Write(IndexString("tokenizerstandard"));

WriteLiteral("\", value: \"standard\", selected: object.tokenizer == \"standard\" },\r\n              " +
"              { label: \"");

                                 Write(IndexString("tokenizerngram"));

WriteLiteral(@""", value: ""trigram_tokenizer"", selected: object.tokenizer == ""trigram_tokenizer"" }
                        ]
                    });
                    select.placeAt(node);
                    select.startup();
                    select.on('change', function (value) {
                        window.location = """);

                                      Write(Url.Action("ChangeTokenizer", controllerName));

WriteLiteral(@"?indexName="" + object.index + ""&tokenizer="" + value;
                    });
                }
            },
            actions: {
                label: """",
                renderCell: function (object, value, node) {
                    new Button({
                        label: """);

                           Write(IndexString("delete"));

WriteLiteral("\",\r\n                        iconClass: \"dijitIcon epi-iconTrash\",\r\n              " +
"          onClick: function() {\r\n                            if (confirm(\"");

                                    Write(IndexString("confirmDelete"));

WriteLiteral("\")) {\r\n                                window.location = \"");

                                              Write(Url.Action("DeleteIndex", controllerName));

WriteLiteral(@"?indexName="" + object.index;
                            }
                        }
                    })
                    .placeAt(node)
                    .startup();
                }
            }
        };


        var indexGrid = new Grid({
            ""class"": ""epi-grid-height--auto epi-grid--with-border"",
            columns: indexCols
        }, ""indexGrid"");
        indexGrid.renderArray(indexData);
    });
</script>
");

        }
    }
}
#pragma warning restore 1591
