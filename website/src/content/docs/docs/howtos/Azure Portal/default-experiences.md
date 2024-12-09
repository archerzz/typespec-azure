---
title: "Generating experiences in Azure Portal with TypeSpec"
---

Go to the [TypeSpec guide](https://eng.ms/docs/products/azure-portal-framework-ibizafx/declarative/typespec) to learn how to customize your Azure Portal experience, generated by default for your ARM resource type. Azure Resource Providers can apply TypeSpec decorators to generate and brand Azure Portal experiences.

![ts6 (1)](https://github.com/user-attachments/assets/ba080602-0edb-4317-bcae-7dffce687a80)

## About Default Experiences

Azure Portal generates end-to-end experiences automatically, providing Resource Providers with immediate UX in Azure Portal for their resource types. This pipeline runs offline and generates views and an asset for your resource type. These generated experiences done by Azure Portal based on resource type metadata are called "Default Experiences". Leveraging TypeSpec affords Resource Providers with an easy, declarative way of branding and promoting these experiences, as the generated default experience is hidden by default. [Learn more](https://eng.ms/docs/products/azure-portal-framework-ibizafx/declarative/generated)

#### Default experiences include:

| **Browse + Management**       |                                                                                   |
| ----------------------------- | --------------------------------------------------------------------------------- |
| > Global Search               | _Discover resource instances and browse view through search_                      |
| > All Resources               | _Discover resource instances in All Resources and launch Overview UX_             |
| > Browse                      | _Browse and manage resource instances in standard browse view_                    |
| **Overview UX**               |                                                                                   |
| > Commands:                   | Refresh, Delete, Create, Open in mobile, CMD by REST-API-SPEC (w/out params)      |
| > Tabs:                       | Get Started template, Properties, Monitoring, Recommendations                     |
| > Essentials                  | _Enable essentials control_                                                       |
| **Resource Menu**             |                                                                                   |
| > Standard Framework Options: | Support + Troubleshooting, Activity Log, IAM, Tags, Monitoring, Diagnostics, etc. |
| > Properties view             | _Enable properties view for resource_                                             |
| > CLI / PS view               | _Enable CLI / PS view for resource_                                               |
| > Child Browse views          | _View child resources in menu_                                                    |

![alt-text](https://github.com/Azure/portaldocs/raw/main/portal-sdk/media/top-extensions-autogeneration/GeneratedOverviewTabs.jpg "Overview blade breakdown")

## Promoting generated experiences to production

See [Promoting Default Experiences](https://eng.ms/docs/products/azure-portal-framework-ibizafx/declarative/promotion) to learn how to promote your default generated Portal experience using TypeSpec.