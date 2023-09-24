﻿using System.Text.Json;
using BlackRevival.APIServer.Classes;
using BlackRevival.APIServer.Database;
using BlackRevival.Common.Enums;
using BlackRevival.Common.GameDB.Roulette;
using BlackRevival.Common.Model;
using BlackRevival.Common.Responses;
using Microsoft.AspNetCore.Mvc;
using UserAsset = BlackRevival.Common.Model.UserAsset;

namespace BlackRevival.APIServer.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private readonly AppDbContext _context;
    private readonly DatabaseHelper _helper;

    public ProductsController(ILogger<ProductsController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
        _helper = new DatabaseHelper(_context);
    }   
    
    [HttpGet("/api/products/all", Name = "GetAllProducts")]
    public IActionResult GetAllCharacters()
    {
        string jsonString =
            "{\"userPromotions\":[],\"purchaseHistories\":[],\"ownSkins\":[{\"unm\":7562069,\"cls\":1,\"ckt\":101,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":4,\"ckt\":401,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":6,\"ckt\":601,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":10,\"ckt\":1001,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":13,\"ckt\":1301,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":23,\"ckt\":2301,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":29,\"ckt\":2901,\"own\":true,\"live\":false,\"setp\":1},{\"unm\":7562069,\"cls\":35,\"ckt\":3501,\"own\":true,\"live\":false,\"setp\":1}],\"characters\":[{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":37,\"crd\":1,\"ast\":3701,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":53,\"crd\":1,\"ast\":5301,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":34,\"crd\":1,\"ast\":3401,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":19,\"crd\":1,\"ast\":1901,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136638,\"unm\":7562069,\"unn\":\"\",\"cls\":13,\"crd\":5,\"ast\":1301,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":49,\"crd\":1,\"ast\":4901,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":39,\"crd\":1,\"ast\":3901,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":5,\"crd\":1,\"ast\":501,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":40,\"crd\":1,\"ast\":4001,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136637,\"unm\":7562069,\"unn\":\"\",\"cls\":10,\"crd\":5,\"ast\":1001,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":17,\"crd\":1,\"ast\":1701,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":25,\"crd\":1,\"ast\":2501,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":27,\"crd\":1,\"ast\":2701,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":22,\"crd\":1,\"ast\":2201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":31,\"crd\":1,\"ast\":3101,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":16,\"crd\":1,\"ast\":1601,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":33,\"crd\":1,\"ast\":3301,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136640,\"unm\":7562069,\"unn\":\"\",\"cls\":29,\"crd\":5,\"ast\":2901,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":24,\"crd\":1,\"ast\":2401,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":8,\"crd\":1,\"ast\":801,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136636,\"unm\":7562069,\"unn\":\"\",\"cls\":23,\"crd\":5,\"ast\":2301,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":28,\"crd\":1,\"ast\":2801,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":2,\"crd\":1,\"ast\":201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":11,\"crd\":1,\"ast\":1101,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":15,\"crd\":1,\"ast\":1501,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":14,\"crd\":1,\"ast\":1401,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":51,\"crd\":1,\"ast\":5101,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":7,\"crd\":1,\"ast\":701,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":52,\"crd\":1,\"ast\":5201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":50,\"crd\":1,\"ast\":5001,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":26,\"crd\":1,\"ast\":2601,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":32,\"crd\":1,\"ast\":3201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":30,\"crd\":1,\"ast\":3001,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":12,\"crd\":1,\"ast\":1201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":38,\"crd\":1,\"ast\":3801,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136633,\"unm\":7562069,\"unn\":\"\",\"cls\":4,\"crd\":1,\"ast\":401,\"l2d\":false,\"ehx\":0,\"cpt\":2,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":46,\"crd\":1,\"ast\":4601,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":18,\"crd\":1,\"ast\":1801,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136639,\"unm\":7562069,\"unn\":\"\",\"cls\":6,\"crd\":5,\"ast\":601,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":3,\"crd\":1,\"ast\":301,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136635,\"unm\":7562069,\"unn\":\"\",\"cls\":35,\"crd\":5,\"ast\":3501,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":36,\"crd\":1,\"ast\":3601,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":21,\"crd\":1,\"ast\":2101,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":41,\"crd\":1,\"ast\":4101,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":20,\"crd\":1,\"ast\":2001,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":47,\"crd\":1,\"ast\":4701,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":45,\"crd\":1,\"ast\":4501,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":44,\"crd\":1,\"ast\":4401,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136634,\"unm\":7562069,\"unn\":\"\",\"cls\":1,\"crd\":5,\"ast\":101,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":42,\"crd\":1,\"ast\":4201,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":43,\"crd\":1,\"ast\":4301,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":9,\"crd\":1,\"ast\":901,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":0,\"unm\":0,\"unn\":\"\",\"cls\":48,\"crd\":1,\"ast\":4801,\"l2d\":false,\"ehx\":0,\"cpt\":0,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0}],\"promotions\":[{\"pt\":2,\"pmd\":1781,\"pid\":\"CHGM051\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000},{\"pt\":2,\"pmd\":1782,\"pid\":\"CHGM030\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000},{\"pt\":2,\"pmd\":1783,\"pid\":\"CHGM019\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000},{\"pt\":2,\"pmd\":1784,\"pid\":\"CSGM060\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000},{\"pt\":2,\"pmd\":1785,\"pid\":\"CSGM283\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000},{\"pt\":2,\"pmd\":1786,\"pid\":\"CSGM168\",\"dpc\":50,\"bgd\":1665414000000,\"edt\":1666018799000}],\"productIds\":[\"CHGD022\",\"CHGD023\",\"CHGD020\",\"CHGD021\",\"LT052\",\"CHGD028\",\"CHGD029\",\"CHGD026\",\"CHGD027\",\"CHGD024\",\"CHGD025\",\"LT055\",\"LT058\",\"CHGD011\",\"CHGD012\",\"CHGD010\",\"CHGD019\",\"CHGD017\",\"CHGD018\",\"LT064\",\"CHGD015\",\"CHGD016\",\"CHGD013\",\"LT061\",\"CHGD014\",\"LT067\",\"MLTP001\",\"MLTP002\",\"CHGD044\",\"MLTP007\",\"CHGD045\",\"MLTP008\",\"CHGD042\",\"MLTP009\",\"CHGD043\",\"CHGD040\",\"BG103\",\"MLTP003\",\"CHGD041\",\"BG102\",\"MLTP004\",\"BG101\",\"MLTP005\",\"BG100\",\"MLTP006\",\"BG106\",\"BG105\",\"BG104\",\"LT031\",\"CHGD048\",\"CHGD049\",\"CHGD046\",\"CHGD047\",\"LT037\",\"LT034\",\"CHGD033\",\"CHGD034\",\"CHGD031\",\"CHGD032\",\"CHGD030\",\"LT040\",\"CHGD039\",\"LT043\",\"CHGD037\",\"CHGD038\",\"CHGD035\",\"CHGD036\",\"LT049\",\"LT046\",\"CSGM390\",\"CSGM391\",\"CSGM392\",\"CSGM393\",\"CSGM394\",\"CSGM395\",\"CSGM396\",\"CSGM397\",\"LT097\",\"LT091\",\"LT094\",\"CSGM380\",\"CSGM381\",\"CSGM382\",\"CSGM383\",\"CSGM384\",\"CHGD053\",\"CSGM385\",\"CSGM386\",\"CHGD051\",\"CSGM387\",\"CHGD052\",\"CSGM388\",\"CSGM389\",\"CHGD050\",\"CSGM370\",\"CSGM371\",\"CSGM372\",\"CSGM373\",\"CSGM374\",\"CSGM375\",\"CSGM376\",\"CSGM377\",\"CSGM378\",\"CSGM379\",\"CSGM369\",\"LT073\",\"LT076\",\"LT070\",\"LT079\",\"CSGM360\",\"CSGM361\",\"CSGM362\",\"CSGM363\",\"CSGM364\",\"CSGM365\",\"CSGM366\",\"CSGM367\",\"CSGM368\",\"CSGM358\",\"LT085\",\"CSGM359\",\"LT082\",\"LT088\",\"PKAP012\",\"LST005\",\"PKAP011\",\"LST006\",\"PKAP010\",\"LST007\",\"LST008\",\"LST009\",\"CSGM350\",\"PKAP019\",\"CSGM351\",\"PKAP018\",\"CSGM352\",\"PKAP017\",\"CSGM353\",\"PKAP016\",\"CSGM354\",\"LST001\",\"PKAP015\",\"CSGM355\",\"LST002\",\"PKAP014\",\"CSGM356\",\"LST003\",\"PKAP013\",\"CSGM357\",\"LST004\",\"CSGM347\",\"CSGM348\",\"CSGM349\",\"PKAP001\",\"PKAP009\",\"PKAP008\",\"CSGM340\",\"PKAP007\",\"CSGM341\",\"PKAP006\",\"CSGM342\",\"PKAP005\",\"CSGM343\",\"PKAP004\",\"CSGM344\",\"PKAP003\",\"CSGM345\",\"PKAP002\",\"CSGM346\",\"CSGM336\",\"CSGM337\",\"CSGM338\",\"CSGM339\",\"PKAP034\",\"PKAP033\",\"ALE002\",\"PKAP032\",\"PKAP031\",\"PKAP030\",\"RLSG003\",\"RLSG004\",\"CSGM330\",\"CSGM331\",\"CSGM332\",\"ALE001\",\"CSGM333\",\"CSGM334\",\"CSGM335\",\"CSGM325\",\"CSGM326\",\"CSGM327\",\"CSGM328\",\"CSGM329\",\"PKAP023\",\"MSC101\",\"PKAP022\",\"MSC100\",\"PKAP021\",\"MSC103\",\"PKAP020\",\"MSC102\",\"MSC109\",\"MSC108\",\"PKAP029\",\"PKAP028\",\"CSGM320\",\"PKAP027\",\"CSGM321\",\"MSC105\",\"PKAP026\",\"CSGM322\",\"MSC104\",\"ABTP001\",\"PKAP025\",\"CSGM323\",\"MSC107\",\"PKAP024\",\"CSGM324\",\"MSC106\",\"CSGM314\",\"CSGM315\",\"CSGM316\",\"CSGM317\",\"CSGM318\",\"MSC112\",\"LST049\",\"MSC111\",\"MSC114\",\"MSC113\",\"MSC110\",\"LST041\",\"MSC119\",\"LST042\",\"LST043\",\"LST044\",\"CSGM310\",\"MSC116\",\"LST045\",\"CSGM311\",\"MSC115\",\"LST046\",\"CSGM312\",\"MSC118\",\"LST047\",\"CSGM313\",\"MSC117\",\"LST048\",\"CSGM303\",\"CSGM304\",\"CSGM305\",\"CSGM306\",\"CSGM307\",\"CSGM308\",\"CSGM309\",\"LST050\",\"LST051\",\"MSC123\",\"LST038\",\"MSC122\",\"LST039\",\"MSC125\",\"MSC124\",\"MSC121\",\"MSC120\",\"LST030\",\"LST031\",\"LST032\",\"LST033\",\"MSC127\",\"LST034\",\"CSGM300\",\"MSC126\",\"LST035\",\"CSGM301\",\"MSC129\",\"LST036\",\"CSGM302\",\"MSC128\",\"LST037\",\"LST040\",\"MSC134\",\"LST027\",\"MSC133\",\"LST028\",\"MSC136\",\"LST029\",\"MSC135\",\"MSC130\",\"MSC132\",\"MSC131\",\"CHGD001\",\"LST021\",\"LST022\",\"MSC138\",\"LST023\",\"MSC137\",\"LST024\",\"LST025\",\"MSC139\",\"LST026\",\"CHGD008\",\"CHGD009\",\"CHGD006\",\"CHGD007\",\"CHGD004\",\"CHGD005\",\"CHGD002\",\"CHGD003\",\"GMIP006\",\"MSC145\",\"LST016\",\"GMIP005\",\"MSC144\",\"LST017\",\"MSC147\",\"LST018\",\"GMIP007\",\"MSC146\",\"MSC141\",\"MSC140\",\"MSC143\",\"MSC142\",\"LST010\",\"LST011\",\"GMIP002\",\"MSC149\",\"LST012\",\"GMIP001\",\"MSC148\",\"LST013\",\"GMIP004\",\"LST014\",\"GMIP003\",\"LST015\",\"MSC156\",\"MSC155\",\"MSC158\",\"MSC157\",\"MSC152\",\"MSC151\",\"MSC154\",\"MSC153\",\"MSC159\",\"MSC150\",\"MSC167\",\"MSC166\",\"MSC169\",\"MSC168\",\"MSC163\",\"MSC162\",\"MSC165\",\"MSC164\",\"MSC161\",\"MSC160\",\"MSC178\",\"MSC177\",\"MSC179\",\"MSC174\",\"MSC173\",\"MSC176\",\"MSC175\",\"MSC170\",\"MSC172\",\"MSC171\",\"MSC189\",\"MSC188\",\"MSC185\",\"MSC184\",\"MSC187\",\"MSC186\",\"PLUB001\",\"PVEFT001\",\"MSC181\",\"MSC180\",\"MSC183\",\"MSC182\",\"MSC199\",\"MSC196\",\"MSC195\",\"MSC198\",\"MSC197\",\"MS012\",\"MS011\",\"MS010\",\"MS016\",\"MS015\",\"MS014\",\"MS013\",\"MS019\",\"MS018\",\"MS017\",\"LTC039\",\"LTC038\",\"LTC037\",\"LTC036\",\"MSC192\",\"LTC035\",\"MSC191\",\"LTC034\",\"MSC194\",\"LTC033\",\"MSC193\",\"LTC032\",\"LTC031\",\"LTC030\",\"MSC190\",\"PTSK008\",\"PTSK006\",\"PTSK007\",\"PTSK004\",\"PTSK005\",\"PTSK002\",\"MS001\",\"PTSK003\",\"PTSK001\",\"MS005\",\"MS004\",\"MS003\",\"MS002\",\"MS009\",\"MS008\",\"MS007\",\"MS006\",\"LTC029\",\"LTC028\",\"LTC027\",\"LTC026\",\"LTC025\",\"LTC024\",\"LTC023\",\"LTC022\",\"LTC021\",\"LTC020\",\"GFLR003\",\"GFLR001\",\"GFLR002\",\"LTC019\",\"LTC018\",\"LTC017\",\"LTC016\",\"LTC015\",\"LTC014\",\"LTC013\",\"LTC012\",\"LTC011\",\"LTC010\",\"LTC009\",\"LTC008\",\"LTC007\",\"LTC006\",\"LTC005\",\"LTC004\",\"LTC003\",\"LTC002\",\"LTC001\",\"BG080\",\"MS052\",\"BG084\",\"MS051\",\"BG083\",\"MS050\",\"BG082\",\"MS056\",\"BG088\",\"APE001\",\"MS055\",\"BG087\",\"MS054\",\"BG086\",\"BG085\",\"APE004\",\"APE005\",\"MS059\",\"APE002\",\"MS058\",\"APE003\",\"BG089\",\"BG091\",\"BG090\",\"BG095\",\"MS040\",\"BG094\",\"BG093\",\"BG092\",\"LT109\",\"BG099\",\"MS044\",\"BG098\",\"MS043\",\"BG097\",\"MS042\",\"BG096\",\"MS048\",\"MS047\",\"MS046\",\"LT103\",\"LT106\",\"LT100\",\"DSG1000\",\"CFVS003\",\"MS030\",\"CFVS002\",\"BG061\",\"CFVS001\",\"MS034\",\"MS033\",\"BG065\",\"MS032\",\"MS031\",\"MS038\",\"MS037\",\"BG069\",\"MS036\",\"RVIP001\",\"MS035\",\"MS039\",\"BG073\",\"MS023\",\"BG077\",\"MS022\",\"MS021\",\"MS020\",\"MS027\",\"MS026\",\"MS025\",\"MS024\",\"BG078\",\"MS029\",\"MS028\",\"LTC043\",\"LTC042\",\"LTC041\",\"LTC040\",\"MS091\",\"MS090\",\"MS095\",\"MS094\",\"MS093\",\"MS099\",\"BG043\",\"MS098\",\"MS097\",\"BG045\",\"BG049\",\"LT130\",\"MS080\",\"MS085\",\"MS084\",\"MS083\",\"MS082\",\"MS089\",\"MS087\",\"BG053\",\"MS086\",\"BG057\",\"MS070\",\"MS074\",\"MS073\",\"LT118\",\"MS071\",\"MS078\",\"BG022\",\"MS076\",\"MS075\",\"BG025\",\"MS079\",\"BG028\",\"LT115\",\"LT112\",\"MS063\",\"MS061\",\"MS060\",\"APE011\",\"APE012\",\"MS066\",\"MS065\",\"BG031\",\"APE010\",\"MS064\",\"BG037\",\"APE013\",\"MS069\",\"MS068\",\"BG034\",\"APE008\",\"APE009\",\"APE006\",\"APE007\",\"GBCH001\",\"LT127\",\"LT121\",\"LT124\",\"CSGM079\",\"CSGM078\",\"CSGM077\",\"CSGM076\",\"CSGM075\",\"CSGM074\",\"CSGM073\",\"CSGM072\",\"CSGM071\",\"CSGM070\",\"CEB001\",\"EVT_001\",\"BGC104\",\"BGC103\",\"CSGM069\",\"BGC102\",\"CSGM068\",\"BGC101\",\"CSGM067\",\"BGC100\",\"CSGM066\",\"CSGM065\",\"CSGM064\",\"CSGM063\",\"CSGM062\",\"CSGM061\",\"CSGM060\",\"BGC105\",\"PKDL002\",\"PKDL001\",\"CSGM059\",\"CSGM058\",\"CSGM057\",\"CSGM056\",\"CSGM055\",\"CSGM054\",\"CSGM053\",\"CSGM052\",\"CSGM051\",\"CSGM050\",\"PKDL003\",\"CSGM039\",\"CSGM049\",\"CSGM048\",\"CSGM047\",\"CSGM046\",\"CSGM045\",\"CSGM042\",\"CSGM041\",\"CSGM040\",\"TRS002\",\"TRS001\",\"TRS004\",\"TRS003\",\"TRS006\",\"TRS005\",\"TRS008\",\"TRS007\",\"CSGM029\",\"CSGM028\",\"CSGM038\",\"CSGM037\",\"CSGM036\",\"CSGM035\",\"CSGM034\",\"CSGM033\",\"CSGM032\",\"CSGM031\",\"CSGM030\",\"CSGM019\",\"CSGM018\",\"CSGM017\",\"CSGM027\",\"CSGM026\",\"CSGM025\",\"CSGM024\",\"CSGM023\",\"CSGM022\",\"CSGM021\",\"CSGM020\",\"CSGM009\",\"CSGM008\",\"CSGM007\",\"CSGM006\",\"CSGM016\",\"CSGM015\",\"CSGM014\",\"CSGM013\",\"CSGM012\",\"CSGM011\",\"CSGM010\",\"GBAS001\",\"CSGM005\",\"CSGM004\",\"CSGM003\",\"CSGM002\",\"CSGM001\",\"CRGD001\",\"MSC200\",\"MSC202\",\"MSC201\",\"MSC208\",\"MSC207\",\"MSC209\",\"MSC204\",\"MSC203\",\"MSC206\",\"MSC205\",\"MSC211\",\"MSC210\",\"MSC213\",\"MSC212\",\"MSC219\",\"MSC218\",\"MSC215\",\"MSC214\",\"MSC217\",\"MSC216\",\"AN001\",\"MSC221\",\"MSC220\",\"EMIP003\",\"EMIP001\",\"EMIP002\",\"PVECT001\",\"SBGM002\",\"SBGM001\",\"SBGM003\",\"DEM3\",\"RLBP006\",\"RLBP005\",\"CRE001\",\"MCC100\",\"MCC101\",\"MCC102\",\"MCC103\",\"MCC104\",\"MCC105\",\"MCC106\",\"TTP008\",\"TTP003\",\"TTP002\",\"TTP001\",\"TTP007\",\"TTP006\",\"TTP005\",\"TTP004\",\"RLEV003\",\"PTSK105\",\"PTSK106\",\"PTSK103\",\"PTSK104\",\"PTSK101\",\"PTSK102\",\"GBGM003\",\"GBGM001\",\"GBGM002\",\"LT019\",\"LT010\",\"LT016\",\"LT013\",\"EBGM003\",\"EBGM001\",\"EBGM002\",\"LT028\",\"LT022\",\"LT025\",\"CSGM099\",\"CSGM098\",\"CSGM097\",\"CSGM096\",\"CSGM095\",\"CSGM094\",\"CSGM093\",\"CSGM092\",\"CSGM091\",\"CSGM090\",\"CSGM089\",\"CSGM088\",\"CSGM087\",\"CSGM086\",\"CSGM085\",\"CSGM084\",\"LT004\",\"CSGM083\",\"LT007\",\"CSGM082\",\"CSGM081\",\"CSGM080\",\"LT002\",\"SDC056\",\"SDC055\",\"CSGM190\",\"SDC054\",\"CSGM191\",\"SDC053\",\"CSGM192\",\"SDC052\",\"CSGM193\",\"SDC051\",\"CSGM194\",\"SDC050\",\"CSGM195\",\"CSGM196\",\"BF031\",\"CSGM197\",\"BF032\",\"CSGM198\",\"CSGM199\",\"BF030\",\"BF035\",\"BF036\",\"BF033\",\"BF034\",\"BF039\",\"BF037\",\"BF038\",\"SDC049\",\"SDC048\",\"SDC047\",\"SDC046\",\"SDC045\",\"SDC044\",\"SDC043\",\"CSGM180\",\"SDC042\",\"CSGM181\",\"SDC041\",\"CSGM182\",\"SDC040\",\"CSGM183\",\"CSGM184\",\"CSGM185\",\"BF042\",\"CSGM186\",\"BF043\",\"CSGM187\",\"BF040\",\"CSGM188\",\"BF041\",\"CSGM189\",\"BF046\",\"BF047\",\"BF044\",\"BF045\",\"BF048\",\"BF049\",\"SDC039\",\"SDC038\",\"SDC037\",\"SDC036\",\"SDC035\",\"SDC034\",\"SDC033\",\"SDC032\",\"SDC031\",\"CSGM170\",\"SDC030\",\"CSGM171\",\"CSGM172\",\"CSGM173\",\"CSGM174\",\"CSGM175\",\"BF010\",\"CSGM176\",\"CSGM177\",\"CSGM178\",\"BF013\",\"CSGM179\",\"BF014\",\"BF011\",\"BF012\",\"BF017\",\"BGC016\",\"BF018\",\"BGC015\",\"BF015\",\"BGC014\",\"BF016\",\"BGC013\",\"BGC012\",\"BGC011\",\"BF019\",\"BGC010\",\"SDC029\",\"SDC028\",\"SDC027\",\"BGC019\",\"SDC026\",\"BGC018\",\"SDC025\",\"BGC017\",\"SDC024\",\"SDC023\",\"SDC022\",\"SDC021\",\"SDC020\",\"CSGM160\",\"CSGM161\",\"CSGM162\",\"CSGM163\",\"BF020\",\"CSGM164\",\"BF021\",\"CSGM165\",\"CSGM166\",\"CSGM167\",\"BF024\",\"CSGM168\",\"BF025\",\"CSGM169\",\"BF022\",\"BF023\",\"BF028\",\"BGC005\",\"BF029\",\"BGC004\",\"BF026\",\"BGC003\",\"BF027\",\"BGC002\",\"BGC001\",\"SDC019\",\"SDC018\",\"SDC017\",\"BGC009\",\"SDC016\",\"BGC008\",\"SDC015\",\"BGC007\",\"SDC014\",\"BGC006\",\"SDC013\",\"CSGM150\",\"CSGM151\",\"CSGM152\",\"CSGM153\",\"CSGM154\",\"CSGM155\",\"CSGM156\",\"CSGM157\",\"CSGM158\",\"CSGM159\",\"CSGM149\",\"CSGM140\",\"CSGM141\",\"CSGM142\",\"CSGM143\",\"CSGM144\",\"CSGM145\",\"BF002\",\"CSGM146\",\"BF003\",\"CSGM147\",\"CSGM148\",\"BF001\",\"CSGM138\",\"BF006\",\"CSGM139\",\"BF007\",\"BF004\",\"BF005\",\"BF008\",\"BF009\",\"SDC072\",\"SDC071\",\"CSGM130\",\"SDC070\",\"CSGM131\",\"CSGM132\",\"CSGM133\",\"CSGM134\",\"CSGM135\",\"CSGM136\",\"CSGM137\",\"CSGM127\",\"CSGM128\",\"CSGM129\",\"PLUEP001\",\"SDC069\",\"SDC068\",\"SDC067\",\"SDC066\",\"SDC065\",\"SDC064\",\"SDC063\",\"SDC062\",\"SDC061\",\"SDC060\",\"CSGM120\",\"CSGM121\",\"CSGM122\",\"CSGM123\",\"CSGM124\",\"CSGM125\",\"CSGM126\",\"CSGM116\",\"CSGM117\",\"CSGM118\",\"CSGM119\",\"SDC059\",\"SDC058\",\"SDC057\",\"BGC074\",\"BGC073\",\"CSGM110\",\"BGC072\",\"MCC050\",\"CSGM111\",\"BGC071\",\"MCC051\",\"CSGM112\",\"BGC070\",\"CSGM113\",\"CSGM114\",\"CSGM115\",\"CSGM105\",\"MCC045\",\"CSGM106\",\"MCC046\",\"CSGM107\",\"MCC047\",\"CSGM108\",\"BGC079\",\"MCC048\",\"CSGM109\",\"BGC078\",\"MCC041\",\"BGC077\",\"MCC042\",\"BGC076\",\"MCC043\",\"BGC075\",\"MCC044\",\"MCC049\",\"BGC063\",\"BGC062\",\"BGC061\",\"CSGM100\",\"BGC060\",\"MCC040\",\"CSGM101\",\"CSGM102\",\"NPE002\",\"CSGM103\",\"NPE001\",\"CSGM104\",\"NPE004\",\"MCC034\",\"NPE003\",\"MCC035\",\"BGC069\",\"MCC036\",\"BGC068\",\"MCC037\",\"BGC067\",\"MCC030\",\"BGC066\",\"MCC031\",\"BGC065\",\"MCC032\",\"BGC064\",\"MCC033\",\"MCC038\",\"MCC039\",\"CHGM016\",\"CHGM017\",\"CHGM014\",\"CHGM015\",\"CHGM018\",\"CHGM019\",\"BGC096\",\"MCC070\",\"BGC095\",\"MCC071\",\"BGC094\",\"MCC072\",\"BGC093\",\"MCC073\",\"CHGM012\",\"BGC092\",\"CHGM013\",\"BGC091\",\"CHGM010\",\"BGC090\",\"PLUHR001\",\"CHGM011\",\"MCC067\",\"MCC068\",\"MCC069\",\"MCC063\",\"BGC099\",\"MCC064\",\"BGC098\",\"MCC065\",\"BGC097\",\"MCC066\",\"CHGM005\",\"CHGM006\",\"CHGM003\",\"CHGM004\",\"CHGM009\",\"CHGM007\",\"CHGM008\",\"BGC085\",\"BGC084\",\"MCC060\",\"BGC083\",\"MCC061\",\"BGC082\",\"MCC062\",\"CHGM001\",\"BGC081\",\"CHGM002\",\"BGC080\",\"MCC056\",\"MCC057\",\"MCC058\",\"MCC059\",\"BGC089\",\"MCC052\",\"BGC088\",\"MCC053\",\"BGC087\",\"MCC054\",\"BGC086\",\"MCC055\",\"CHGM038\",\"SDC012\",\"CHGM039\",\"SDC011\",\"CHGM036\",\"SDC010\",\"CHGM037\",\"CHGM030\",\"BGC030\",\"MCC092\",\"CHGM031\",\"MCC093\",\"CHGM034\",\"CHGM035\",\"CHGM032\",\"MCC090\",\"CHGM033\",\"CVE001\",\"MCC091\",\"BGC038\",\"MCC089\",\"BGC037\",\"BGC036\",\"BGC035\",\"BGC034\",\"MCC085\",\"BGC033\",\"MCC086\",\"BGC032\",\"MCC087\",\"BGC031\",\"MCC088\",\"SDC009\",\"SDC008\",\"SDC007\",\"SDC006\",\"SDC005\",\"SDC004\",\"SDC003\",\"BGC039\",\"SDC002\",\"CHGM027\",\"EMC005\",\"SDC001\",\"CHGM028\",\"EMC006\",\"CHGM025\",\"EMC003\",\"CHGM026\",\"EMC004\",\"EMC009\",\"CHGM029\",\"EMC007\",\"EMC008\",\"MCC081\",\"CHGM020\",\"MCC082\",\"MCC083\",\"PLUW001\",\"MCC084\",\"CHGM023\",\"EMC001\",\"CHGM024\",\"EMC002\",\"CHGM021\",\"CHGM022\",\"MCC080\",\"BGC027\",\"MCC078\",\"BGC026\",\"MCC079\",\"BGC025\",\"BGC024\",\"BGC023\",\"MCC074\",\"BGC022\",\"MCC075\",\"BGC021\",\"MCC076\",\"BGC020\",\"MCC077\",\"BGC029\",\"BGC028\",\"EMC016\",\"EMC017\",\"EMC014\",\"EMC015\",\"EMC018\",\"EMC019\",\"CHGM052\",\"BGC052\",\"CHGM053\",\"BGC051\",\"CHGM050\",\"BGC050\",\"CHGM051\",\"EMC012\",\"PLUL001\",\"EMC013\",\"EMC010\",\"EMC011\",\"BGC059\",\"BGC058\",\"BGC057\",\"BGC056\",\"BGC055\",\"BGC054\",\"BGC053\",\"CHGM049\",\"EMC027\",\"EMC028\",\"CHGM047\",\"EMC025\",\"CHGM048\",\"EMC026\",\"EMC029\",\"CHGM041\",\"BGC041\",\"CHGM042\",\"BGC040\",\"EMC020\",\"CHGM040\",\"CHGM045\",\"EMC023\",\"CHGM046\",\"EMC024\",\"CHGM043\",\"EMC021\",\"CHGM044\",\"EMC022\",\"BGC049\",\"BGC048\",\"BGC047\",\"BGC046\",\"BGC045\",\"BGC044\",\"BGC043\",\"BGC042\",\"CV082\",\"CV081\",\"CV080\",\"CV089\",\"CV088\",\"CV087\",\"CV086\",\"CV085\",\"CV084\",\"CV083\",\"CV093\",\"CV092\",\"CV091\",\"CV090\",\"MS201\",\"MS200\",\"CV094\",\"BB001\",\"CV060\",\"CV068\",\"CV067\",\"CV066\",\"CV065\",\"CV064\",\"CV063\",\"CV062\",\"CV061\",\"CV059\",\"CV058\",\"CV071\",\"CV070\",\"CV079\",\"CV078\",\"CV077\",\"CV076\",\"CV075\",\"CV074\",\"CV073\",\"CV072\",\"NCGM001\",\"NCGM002\",\"CV069\",\"PKIP003\",\"PKIP002\",\"CV046\",\"CV045\",\"CV044\",\"CV043\",\"CV042\",\"CV041\",\"CV040\",\"CV039\",\"CV038\",\"CV037\",\"CV036\",\"PKIP001\",\"PKFI001\",\"PKFI002\",\"PKFI003\",\"CV057\",\"CV056\",\"CV055\",\"CV054\",\"CV053\",\"CV052\",\"CV051\",\"CV050\",\"PLUBF001\",\"CV049\",\"PLUD001\",\"CV048\",\"CV047\",\"CV024\",\"CV023\",\"CV022\",\"CV021\",\"CV020\",\"MCC023\",\"MCC024\",\"CV019\",\"MCC025\",\"CV018\",\"MCC026\",\"CV017\",\"CV016\",\"MCC020\",\"CV015\",\"MCC021\",\"CV014\",\"MCC022\",\"MCC027\",\"MCC028\",\"MCC029\",\"CV035\",\"CV034\",\"CV033\",\"CV032\",\"CV031\",\"CV030\",\"MCC012\",\"MCC013\",\"MCC014\",\"CV029\",\"MCC015\",\"CV028\",\"CV027\",\"CV026\",\"MCC010\",\"CV025\",\"MCC011\",\"MCC016\",\"MCC017\",\"MCC018\",\"MCC019\",\"CV002\",\"TT010\",\"CV001\",\"GDGM003\",\"GDGM004\",\"CV013\",\"CV012\",\"CV011\",\"CV010\",\"CV009\",\"CV008\",\"CV007\",\"CV006\",\"CV005\",\"CV004\",\"CV003\",\"GDGM001\",\"GDGM002\",\"TTS001\",\"TT001\",\"AR002\",\"AR001\",\"BF152\",\"BF153\",\"BF150\",\"BF151\",\"BF156\",\"BF157\",\"BF154\",\"BF155\",\"BG001\",\"BG007\",\"BF158\",\"BG006\",\"BF159\",\"BF160\",\"BF163\",\"BF164\",\"BG010\",\"BF161\",\"BF162\",\"BF167\",\"BF168\",\"BF165\",\"BG013\",\"BF166\",\"BG019\",\"BF169\",\"BG016\",\"CSGM290\",\"CSGM291\",\"CSGM292\",\"CSGM293\",\"CSGM294\",\"CSGM295\",\"BF130\",\"CSGM296\",\"BF131\",\"CSGM297\",\"CSGM298\",\"LBM001\",\"CSGM299\",\"BF134\",\"BF135\",\"BF132\",\"BF133\",\"BF138\",\"BF139\",\"BF136\",\"BF137\",\"LBB001\",\"CSGM280\",\"CSGM281\",\"CSGM282\",\"CSGM283\",\"CSGM284\",\"BF141\",\"MCC07\",\"CSGM285\",\"BF142\",\"MCC08\",\"CSGM286\",\"MCC09\",\"CSGM287\",\"BF140\",\"CSGM288\",\"BF145\",\"MCC03\",\"CSGM289\",\"BF146\",\"MCC04\",\"BF143\",\"MCC05\",\"BF144\",\"MCC06\",\"BF149\",\"MCC00\",\"BF147\",\"MCC01\",\"BF148\",\"MCC02\",\"CSGM270\",\"CSGM271\",\"CSGM272\",\"CSGM273\",\"CSGM274\",\"CSGM275\",\"CSGM276\",\"CSGM277\",\"BF112\",\"CSGM278\",\"BF113\",\"CSGM279\",\"BF110\",\"BF111\",\"BF116\",\"BF117\",\"BF114\",\"BF115\",\"BF118\",\"BF119\",\"CSGM260\",\"CSGM261\",\"CSGM262\",\"CSGM263\",\"BF120\",\"CSGM264\",\"CSGM265\",\"CSGM266\",\"BF123\",\"CSGM267\",\"BF124\",\"CSGM268\",\"BF121\",\"CSGM269\",\"BF122\",\"CSGM259\",\"BF127\",\"BF128\",\"BF125\",\"BF126\",\"BF129\",\"PPE004\",\"PPE003\",\"PPE002\",\"PPE001\",\"CSGM250\",\"CSGM251\",\"CSGM252\",\"CSGM254\",\"CSGM255\",\"CSGM256\",\"CSGM257\",\"CSGM258\",\"CSGM248\",\"CSGM249\",\"PPE007\",\"PPE006\",\"PPE005\",\"CSGM240\",\"CSGM241\",\"CSGM242\",\"CSGM243\",\"CSGM244\",\"BF101\",\"CSGM245\",\"BF102\",\"CSGM246\",\"CSGM247\",\"BF100\",\"CSGM237\",\"BF105\",\"CSGM238\",\"BF106\",\"CSGM239\",\"BF103\",\"BF104\",\"BF109\",\"BF107\",\"BF108\",\"TSLT002\",\"CSGM230\",\"TSLT001\",\"CSGM231\",\"CSGM232\",\"CSGM233\",\"CSGM234\",\"CSGM235\",\"CSGM236\",\"TSLT003\",\"MCC98\",\"CSGM227\",\"MCC99\",\"CSGM228\",\"CSGM229\",\"MCC94\",\"MCC95\",\"MCC96\",\"MCC97\",\"ABVS001\",\"CSGM220\",\"CSGM221\",\"CSGM222\",\"CSGM223\",\"CSGM224\",\"CSGM225\",\"CSGM215\",\"CSGM216\",\"CSGM217\",\"CSGM218\",\"CSGM219\",\"CSGM210\",\"CSGM212\",\"CSGM213\",\"CSGM214\",\"CSGM204\",\"CSGM205\",\"CSGM206\",\"CSGM207\",\"CSGM208\",\"CSGM209\",\"CSGM200\",\"CSGM201\",\"CSGM202\",\"CSGM203\",\"MSC002\",\"MSC001\",\"MSC004\",\"MSC003\",\"MSC009\",\"MSC006\",\"MSC005\",\"MSC008\",\"MSC007\",\"MSC013\",\"MSC012\",\"MSC015\",\"MSC014\",\"MSC011\",\"MSC010\",\"MSC017\",\"MSC016\",\"MSC019\",\"MSC018\",\"MSC024\",\"MSC023\",\"MSC026\",\"MSC025\",\"MSC020\",\"MSC022\",\"MSC021\",\"MSC028\",\"MSC027\",\"MSC029\",\"MSC035\",\"EMC038\",\"MSC034\",\"EMC039\",\"MSC037\",\"EMC036\",\"MSC036\",\"EMC037\",\"MSC031\",\"MSC030\",\"MSC033\",\"MSC032\",\"EMC030\",\"EMC031\",\"MSC039\",\"EMC034\",\"MSC038\",\"EMC035\",\"EMC032\",\"EMC033\",\"MSC046\",\"PLUFX001\",\"CVVS004\",\"EMC049\",\"MSC045\",\"CVVS005\",\"MSC048\",\"EMC047\",\"MSC047\",\"EMC048\",\"MSC042\",\"MSC041\",\"CVVS001\",\"MSC044\",\"CVVS002\",\"MSC043\",\"CVVS003\",\"EMC041\",\"EMC042\",\"EMC040\",\"EMC045\",\"MSC049\",\"EMC046\",\"EMC043\",\"EMC044\",\"MSC040\",\"MSC057\",\"MSC056\",\"MSC059\",\"EMC058\",\"MSC058\",\"EMC059\",\"MSC053\",\"MSC052\",\"MSC055\",\"MSC054\",\"EMC052\",\"EMC053\",\"EMC050\",\"EMC051\",\"EMC056\",\"EMC057\",\"EMC054\",\"EMC055\",\"MSC051\",\"MSC050\",\"MSC068\",\"MSC067\",\"EMC069\",\"MSC069\",\"MSC064\",\"MSC063\",\"MSC066\",\"MSC065\",\"LST052\",\"EMC063\",\"LST053\",\"EMC064\",\"LST054\",\"EMC061\",\"EMC062\",\"EMC067\",\"EMC065\",\"EMC066\",\"EMC060\",\"MSC060\",\"MSC062\",\"MSC061\",\"MSC079\",\"MSC078\",\"MSC075\",\"MSC074\",\"MSC077\",\"MSC076\",\"MS133\",\"MS131\",\"EMC072\",\"MS130\",\"MS137\",\"EMC078\",\"MS135\",\"MS134\",\"MS139\",\"MS138\",\"EMC070\",\"EMC071\",\"MSC071\",\"MSC070\",\"MSC073\",\"MSC072\",\"RDNA001\",\"MSC089\",\"MSC086\",\"MSC085\",\"MSC088\",\"MSC087\",\"MS122\",\"MS121\",\"MS126\",\"MS125\",\"MS123\",\"MS129\",\"MS127\",\"MSC082\",\"MSC081\",\"MSC084\",\"MSC083\",\"MSC080\",\"MSC097\",\"MSC096\",\"MSC099\",\"MSC098\",\"MS111\",\"MS110\",\"MS115\",\"MS114\",\"MS113\",\"MS119\",\"MS118\",\"MS117\",\"MSC093\",\"MSC092\",\"MSC095\",\"MSC094\",\"MSC091\",\"MSC090\",\"MS103\",\"MS102\",\"MS101\",\"MS107\",\"MS106\",\"MS105\",\"MS109\",\"MS173\",\"BGM10\",\"MS171\",\"MS170\",\"MS177\",\"BGM13\",\"MS175\",\"BGM12\",\"MS174\",\"BGM11\",\"MS179\",\"MS178\",\"MS162\",\"MS161\",\"MS166\",\"MS165\",\"MS163\",\"MS169\",\"MS167\",\"BF090\",\"MS151\",\"BF093\",\"MS150\",\"BF094\",\"BF091\",\"BF092\",\"MS155\",\"BF097\",\"MS154\",\"BF098\",\"MS153\",\"BF095\",\"BF096\",\"MS159\",\"MS158\",\"MS157\",\"BF099\",\"BGM03\",\"MS143\",\"BGM02\",\"MS142\",\"BGM01\",\"MS141\",\"BGM07\",\"MS147\",\"BGM06\",\"MS146\",\"BGM05\",\"MS145\",\"BGM04\",\"BGM09\",\"MS149\",\"BGM08\",\"FIAP001\",\"MLTP021\",\"MLTP022\",\"MLTP023\",\"PKNC050\",\"MLTP024\",\"PKNC051\",\"BF071\",\"PKNC052\",\"BF072\",\"PKNC053\",\"BF070\",\"MLTP020\",\"PAPE013\",\"BF075\",\"BF076\",\"BF073\",\"BF074\",\"BF079\",\"MLTP025\",\"PAPE010\",\"MLTP026\",\"PAPE011\",\"BF077\",\"MLTP027\",\"PAPE012\",\"BF078\",\"TS005\",\"TS006\",\"TS003\",\"TS004\",\"TS001\",\"TS002\",\"PKNC044\",\"PKNC045\",\"PKNC046\",\"PKNC047\",\"PKNC048\",\"TS009\",\"PKNC049\",\"TS007\",\"TS008\",\"MLTP010\",\"MLTP011\",\"MLTP012\",\"MLTP013\",\"BF082\",\"BF083\",\"BF080\",\"BF081\",\"PAPE002\",\"BF086\",\"MLTP018\",\"PAPE003\",\"BF087\",\"MLTP019\",\"PAPE004\",\"BF084\",\"PAPE005\",\"BF085\",\"MLTP014\",\"MLTP015\",\"BF088\",\"MLTP016\",\"PAPE001\",\"BF089\",\"MLTP017\",\"PAPE006\",\"DCE25\",\"PAPE007\",\"PAPE008\",\"PAPE009\",\"MS191\",\"MS190\",\"MS195\",\"MS194\",\"BF050\",\"MS193\",\"MS199\",\"BF053\",\"MS198\",\"BF054\",\"MS197\",\"BF051\",\"MS196\",\"BF052\",\"BF057\",\"BF058\",\"BF055\",\"BF056\",\"BF059\",\"PKNC040\",\"BF060\",\"PKNC041\",\"MS183\",\"BF061\",\"PKNC042\",\"MS182\",\"PKNC043\",\"MS181\",\"BF064\",\"MS187\",\"BF065\",\"MS186\",\"BF062\",\"MS185\",\"BF063\",\"BF068\",\"BF069\",\"BF066\",\"MS189\",\"BF067\",\"PKNC034\",\"PKNC035\",\"PKNC036\",\"PKNC037\",\"PKNC038\",\"PKNC039\"],\"ownCharacters\":[{\"cnm\":10136634,\"unm\":7562069,\"unn\":\"\",\"cls\":1,\"crd\":5,\"ast\":101,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136633,\"unm\":7562069,\"unn\":\"\",\"cls\":4,\"crd\":1,\"ast\":401,\"l2d\":false,\"ehx\":0,\"cpt\":2,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136639,\"unm\":7562069,\"unn\":\"\",\"cls\":6,\"crd\":5,\"ast\":601,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136637,\"unm\":7562069,\"unn\":\"\",\"cls\":10,\"crd\":5,\"ast\":1001,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136638,\"unm\":7562069,\"unn\":\"\",\"cls\":13,\"crd\":5,\"ast\":1301,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136636,\"unm\":7562069,\"unn\":\"\",\"cls\":23,\"crd\":5,\"ast\":2301,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136640,\"unm\":7562069,\"unn\":\"\",\"cls\":29,\"crd\":5,\"ast\":2901,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0},{\"cnm\":10136635,\"unm\":7562069,\"unn\":\"\",\"cls\":35,\"crd\":5,\"ast\":3501,\"l2d\":false,\"ehx\":0,\"cpt\":1,\"rpc\":0,\"rwc\":0,\"npc\":0,\"nwc\":0,\"tnm\":0,\"psi\":0,\"pmn\":0,\"pfr\":0,\"psd\":0,\"hst\":false,\"ctt\":1,\"nrs\":0}],\"newRequestArrived\":false,\"newProduct\":[{\"pid\":\"PKIP003\",\"ty\":1,\"lt\":3,\"cdt\":1588130625000,\"bdt\":1588086000000,\"edt\":1903100399000},{\"pid\":\"CHGD022\",\"ty\":4,\"lt\":2,\"cdt\":1605669715000,\"bdt\":1605625200000,\"edt\":1889708399000},{\"pid\":\"CHGD005\",\"ty\":4,\"lt\":2,\"cdt\":1605669756000,\"bdt\":1605625200000,\"edt\":1889708399000},{\"pid\":\"CHGM044\",\"ty\":4,\"lt\":2,\"cdt\":1605669775000,\"bdt\":1605625200000,\"edt\":1889708399000},{\"pid\":\"CHGD031\",\"ty\":4,\"lt\":2,\"cdt\":1605669794000,\"bdt\":1605625200000,\"edt\":1889708399000},{\"pid\":\"CHGD012\",\"ty\":4,\"lt\":2,\"cdt\":1605669812000,\"bdt\":1605625200000,\"edt\":1889708399000}]}";
        var skinRes = JsonSerializer.Deserialize<ProductAllResult>(jsonString);
        
        var apiSession = (APISession)HttpContext.Items["Session"];

        var userNum = apiSession.Session.userNum;
        
        
        //Only show our owned skins and characters
        skinRes.ownSkins.Clear();
        skinRes.ownCharacters.Clear();
        var ownedSkins = _helper.GetOwnedCharSkins(userNum).Result;
        foreach (var ownSkin in ownedSkins)
        {
            skinRes.ownSkins.Add(ownSkin);
        }
        
        var ownedCharacters = _helper.GetOwnedCharacters(userNum).Result;
        //Add owned characters to the response skinRes.ownChars 
        foreach (var chars in ownedCharacters)
        {
            skinRes.ownCharacters.Add(new()
            {
                characterNum = chars.CharacterNum,
                userNum = chars.UserNum ?? default(long),
                characterClass = chars.CharacterClass,
                characterGrade = chars.CharacterGrade,
                activeCharacterSkinType = chars.ActiveCharacterSkinType,
                activeLive2D = chars.ActiveLive2D,
                enhanceExp = chars.EnhanceExp,
                characterPurchaseType = chars.CharacterPurchaseType,
                rankPlayCount = chars.RankPlayCount,
                rankWinCount = chars.RankWinCount,
                normalPlayCount = chars.NormalPlayCount,
                normalWinCount = chars.NormalPlayCount,
                teamNumber = chars.TeamNumber,
                potentialSkillId = chars.PotentialSkillId,
                pmn = chars.Pmn,
                pfr = chars.Pfr,
                psd = chars.Psd,
                host = chars.Host,
                characterStatus = chars.CharacterStatus,
                toNormalRemainSeconds = chars.ToNormalRemainSeconds,
                userNickname = chars.UserNickname
            });
        }
        
        
        ProductManager.UpdateAllProduct(skinRes.newProduct, skinRes.promotions, skinRes.userPromotions,
            skinRes.purchaseHistories, skinRes.ownCharacters, skinRes.ownSkins, skinRes.productIds);
        
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "SUCCESS",
            Rst = skinRes,
            Eac = 0,
        });
    }
    
    [HttpGet("/api/products/purchase/normal/{productId}", Name = "GetProduct")]
    public async Task<IActionResult> GetProduct(string productId)
    {
        var session = (APISession)HttpContext.Items["Session"];
        if (session == null)
        {
            return Json(new WebResponseHeader
            {
                Cod = 401,
                Msg = "Session Does not exist",
                Rst = null,
                Eac = 0
            });
        }

        
        var product = TableManager.productsDb.Find(productId);
        
        //Check if the user has enough gems
        var userAsset = _helper.GetUserAssetByUserNum(session.Session.userNum).Result;
        var user = _helper.GetUserByNum(session.Session.userNum).Result;

        if (userAsset.Gem < product.price)
        {
            return Json(new WebResponseHeader
            {
                Cod = 400,
                Msg = "Not enough gems",
                Rst = null,
                Eac = 0
            });
        }
        userAsset.Gem -= (int)product.price;
        await _helper.UpdateUserAsset(session.Session.userNum, userAsset);
        
        var result = new PurchaseResult();
        result.provideResult = new ProvideResult();
        result.provideResult.isDuplication = false;
        result.provideResult.creditBonusRate = 1.0f;
        result.provideResult.results = new List<ProvideResult>();
        /*var provideResult = new ProvideResult();
        provideResult.isDuplication = false;
        provideResult.goods = product.goods;*/
        result.provideResult.isDuplication = false;
        //Add the Database.UserAsset to the result Model.UserAsset
        result.userAsset = new()
        {
            bearPoint = userAsset.BearPoint,
            agliaScore = userAsset.AgliaScore,
            gold = userAsset.Gold,
            gem = userAsset.Gem,
            credit = userAsset.Credit,
            mileage = userAsset.Mileage,
            experimentMemory = userAsset.ExperimentMemory,
            tournamentPoint = userAsset.TournamentPoint,
            tournamentTicket = userAsset.TournamentTicket,
            voteTicket = userAsset.VoteTicket,
            voteStamp = userAsset.VoteStamp,
            labyrinthPoint = userAsset.LabyrinthPoint
        };

        result.attendanceEventRecord = new AttendanceEventRecord()
        {
        };

        var theProduct = TableManager.productsDb.Find(productId);
        switch (theProduct.goods.goodsType)
        {
            case GoodsType.ROULETTE:
                return await GetRoulette(session, theProduct);
            
            //This has to sorted into different endpoints in the meantime we will just return true
            case GoodsType.CHARACTER:
            {
                //Get character data from the product
                var charData = TableManager.characterDb.Find((AcE_CharacterClass)int.Parse(theProduct.goods.subType));
                var skinData = TableManager.skinsDb.GetAllSkins();
                //Get the lowest skin id for that characterclass
                var skin = TableManager.skinsDb.GetFirstSkinId(int.Parse(theProduct.goods.subType));


                //Create the new character for the user
                var newChar = new Database.Character
                {
                    UserNum = session.Session.userNum,
                    UserNickname = user.Nickname,
                    CharacterClass = (int)charData.CharacterClassType,
                    CharacterGrade = CharacterGrade.FIVE_STAR,
                    CharacterPurchaseType = CharacterPurchaseType.PURCHASED,
                    CharacterStatus = CharacterStatus.NORMAL,
                    ActiveCharacterSkinType = skin,
                    ActiveLive2D = false,
                };
                await _helper.CreateCharacter(newChar);
                _logger.LogInformation("Inserted new character {0}.", newChar.CharacterNum);
                //now set the activate character number
                //Also add the new skin for the character
                var newSkin = new OwnedSkin
                {
                    UserNum = session.Session.userNum,
                    CharacterClass = (int)charData.CharacterClassType,
                    CharacterSkinType = skin,
                    Owned = true,
                    ActiveLive2D = false,
                    SkinEnableType = SkinEnableType.PURCHASE
                };
                await _helper.CreateOwnedSkin(newSkin);

                 await _helper.SetActiveCharacter(session.Session.userNum, newChar.CharacterNum);

                 await Task.Delay(100);
                _logger.LogInformation("Set active character to {0}.", newChar.CharacterNum);

                /*provideResult.character = _helper.GetActiveCharacterGameModel(user.UserNum).Result;
                provideResult.characterSkin = new ()
                {
                    userNum = session.Session.userNum,
                    characterClass = (int)charData.CharacterClassType,
                    characterSkinType = skin,
                    owned = true,
                    activeLive2D = false,
                    skinEnableType = SkinEnableType.PURCHASE
                };*/
                result.provideResult.character = _helper.GetActiveCharacterGameModel(user.UserNum).Result;
                result.provideResult.characterSkin= new ()
                {
                    userNum = session.Session.userNum,
                    characterClass = (int)charData.CharacterClassType,
                    characterSkinType = skin,
                    owned = true,
                    activeLive2D = false,
                    skinEnableType = SkinEnableType.PURCHASE
                };
                
            } break;
            case GoodsType.CHARACTER_SKIN:
            {
                var skinData = TableManager.skinsDb.GetAllSkins();
                //Get the lowest skin id for that characterclass
                var skin = TableManager.skinsDb.GetSkinById(int.Parse(theProduct.goods.subType));

                var newSkin = new OwnedSkin
                {
                    UserNum = session.Session.userNum,
                    CharacterClass = skin.characterClass,
                    CharacterSkinType = skin.characterSkinType,
                    Owned = true,
                    ActiveLive2D = skin.activeLive2D,
                    SkinEnableType = SkinEnableType.PURCHASE
                };
                await _helper.CreateOwnedSkin(newSkin);
                result.provideResult.characterSkin = new ()
                {
                    userNum = session.Session.userNum,
                    characterClass = (int)skin.characterClass,
                    characterSkinType = skin.characterSkinType,
                    owned = true,
                    activeLive2D = skin.activeLive2D,
                    skinEnableType = SkinEnableType.PURCHASE
                };

            }
                break;
            
            default:
                break;
        }

        //Now set it as the provides result


        //result.provideResult.results.Add(provideResult);



        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "SUCCESS",
            Rst = result,
            Eac = 0,
        });
    }
    
    [HttpGet("/api/products/purchase/roulette/{Prod}", Name = "GetRoulette")]
    public async Task<IActionResult> GetRoulette(APISession session, Product Prod)
    {
        if (session == null)
        {
            return Json(new WebResponseHeader
            {
                Cod = 401,
                Msg = "Session Does not exist",
                Rst = null,
                Eac = 0
            });
        }
        
        var userAsset = _helper.GetUserAssetByUserNum(session.Session.userNum).Result;
        if (userAsset.Gem < Prod.price)
        {
            return Json(new WebResponseHeader
            {
                Cod = 400,
                Msg = "Not enough gems",
                Rst = null,
                Eac = 0
            });
        }
        
        //update userasset
        userAsset.Gem -= (int)Prod.price;
        await _helper.UpdateUserAsset(session.Session.userNum, userAsset);

        var count = Prod.goods.amount;
        var outlist = new List<RoulettePmf>();
        var type = AcE_ROULETTE_TYPE.SEASON_ROULETTE;
        var product = TableManager.productsDb.FindRouletteList(PurchaseMethod.GEM, count)
            .Find(x => ProductManager.IsAvailableProduct(x.productId, type));

        RouletteData rouletteData = TableManager.productsDb.FindRouletteData(product.goods.subType);
        outlist = (from x in rouletteData.pmf
            where x.goods.goodsType != GoodsType.ASSET || x.ratio > 0.0
            select x).ToList<RoulettePmf>();

        var result = new PurchaseResult();
        result.provideResult = new ProvideResult();
        
        //Generate a random number between 0 and 1
        var random = new Random();
        var randomNumber = random.NextDouble();
        
        //Pool the list of items based on their ratio so you only pull one item out of the list
        var pool = new List<RoulettePmf>();
        foreach (var item in outlist)
        {
            for (var i = 0; i < item.ratio; i++)
            {
                pool.Add(item);
            }
        }
        
        //Get a random item from the pool
        result.provideResult.isDuplication = false;
        result.provideResult.creditBonusRate = 1.0f;
        result.provideResult.results = new List<ProvideResult>();

        for (int i = 0; i < count; i++)
        {
            var randomItem = pool[random.Next(pool.Count)];

            var gachaResult = new ProvideResult();
            gachaResult.rouletteGoods = randomItem.goods;
            gachaResult.invenGoods = new InvenGoods
            {
                a = 1, activated = false, isActivated = false, c = randomItem.goods.goodsCode, num = 1,
                userNum = session.Session.userNum
            };
            gachaResult.isDuplication = false;
            gachaResult.creditBonusRate = 1.0f;
            gachaResult.goods = randomItem.goods;
            result.provideResult.results.Add(gachaResult);
        }
        
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "SUCCESS",
            Rst = result,
            Eac = 0,
        });
    }
    
    [HttpGet("/api/products/purchase/daily/{0}")]
    public IActionResult getDailyProductPurchase()
    {
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "Not yet Implemented",
            Rst = new {},
            Eac = 0
        });
    }
    
    [HttpPost("/api/products/purchase/promotion/{0}/{1}/{2}")]
    public IActionResult postPurchasePromotionPack()
    {
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "Not yet Implemented",
            Rst = new {},
            Eac = 0
        });
    }
    
    [HttpGet("/api/products/new")]
    public IActionResult getProductsNew()
    {
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "Not yet Implemented",
            Rst = new {},
            Eac = 0
        });
    }
    
    [HttpGet("/api/products/purchase/history")]
    public IActionResult getPurchaseHistory()
    {
        return Json(new WebResponseHeader
        {
            Cod = 200,
            Msg = "Not yet Implemented",
            Rst = new {},
            Eac = 0
        });
    }
}