# RLS for Embedded

RLS for Embedded for external customers, also known as AppOwnsData requires you to pass in an JSON array named "identities" when calling the REST API. "Identities" contains "username", list of roles and list of datasets. Below is the code example.
```
{
    "accessLevel": "View",
    "identities": [
        {
            "username": "EffectiveIdentity",
            "roles": [ "Role1", "Role2" ],
            "datasets": [ "fe0a1aeb-f6a4-4b27-a2d3-b5df3bb28bdc" ]
        }
    ]
}
```

## When not using Dynamic RLS

You can use RLS for embedded AppsOwnsData without leveraging [Dynamic RLS](https://github.com/lipinght/PBICookbook/blob/main/RLS/dynamic.md). you will still need to pass in a username. In this case, username can be any string, as long as it is not Null. You will need to set up roles as per the instruction in [Basic RLS](https://github.com/lipinght/PBICookbook/blob/main/RLS/basic.md). When setting up the role in Power BI service, you do not need to put any user to the role. Datasets can be infered by the report or specifically defined, for examples please see the code samples in Userful Links below.

## When using Dynamic RLS

When using Dynamic RLS in embedded, you will need to set up [Dynamic RLS](https://github.com/lipinght/PBICookbook/blob/main/RLS/dynamic.md) first, note it is important that you are using username() instead of userprinciplename() and your security profile table will contain a list of user names that your app will pass in. 

# Useful Links

* [Row-level security with Power BI Embedded](https://docs.microsoft.com/en-us/power-bi/developer/embedded/embedded-row-level-security)
* [RLS .Net Sample](https://docs.microsoft.com/en-us/power-bi/developer/embedded/embedded-row-level-security)
* [RLS Python Flask Sample](https://github.com/lipinght/PBIEmbedRLSFlaskSample)