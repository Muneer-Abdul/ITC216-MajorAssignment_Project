# ITC216 Major Assignment Project

## Viti FoodLink

### A Community Food-Sharing, Surplus Management, and Barter System for Fiji

Viti FoodLink is a Windows desktop application designed to help
communities manage surplus food, connect available produce with people
requesting food, and encourage community exchange through a barter
feature. It brings together surplus management, recipient records,
recommendation support, distribution tracking, food requests, reporting,
and multilingual interface elements.

**Technology:** VB.NET Windows Forms · .NET Framework 4.7.2 · SQLite ·
Visual Studio

> **Project status:** A portable Windows release ZIP has been created
> and tested from an extracted folder. Complete the final user
> acceptance tests before treating the release as production-ready.

## Contents

-   [Project Goals](#project-goals)
-   [Key Features](#key-features)
-   [Technology Stack](#technology-stack)
-   [Application Forms](#application-forms)
-   [User Roles and Permissions](#user-roles-and-permissions)
-   [Typical Workflows](#typical-workflows)
-   [Database](#database)
-   [Languages](#languages)
-   [Run the Application](#run-the-application)
-   [Build from Source](#build-from-source)
-   [Project Structure](#project-structure)
-   [Testing Checklist](#testing-checklist)
-   [Security and Data Notes](#security-and-data-notes)
-   [Future Improvements](#future-improvements)

## Project Goals

-   Make surplus food easier to record and manage.
-   Help connect available produce with people or groups requesting
    food.
-   Support authorised staff in reviewing recommendations and recording
    distributions.
-   Encourage community participation through food barter.
-   Provide food-request and reporting features.
-   Include English, iTaukei, and Fiji Hindi interface support on forms
    where translations have been implemented.
-   Reflect a Fijian community context that encourages sharing,
    cooperation, and reduced food waste.

## Key Features

-   Login and registration with role selection.
-   Role-aware dashboards and navigation.
-   Surplus produce management.
-   Recipient management.
-   Recommendation engine to assist matching produce and recipients
    using project criteria such as produce type and community.
-   Food distribution records and stock updates.
-   Food requests.
-   Barter offers and confirmation tracking.
-   System reports and CSV export where available.
-   User profile features.
-   **VitiBot:** local, rule-based prepared responses; it is not a
    cloud-based generative AI service.
-   Multilingual interface support on implemented forms.
-   SQLite local data persistence.

## Technology Stack

  Technology             Purpose
  ---------------------- ---------------------------------------
  VB.NET                 Application programming language
  Windows Forms          Desktop interface
  .NET Framework 4.7.2   Application framework
  SQLite                 Local relational database
  `System.Data.SQLite`   SQLite access from VB.NET
  Visual Studio          Development and build environment
  Git and GitHub         Source control and repository hosting

## Application Forms

The project uses separate forms for different responsibilities. Exact
actions available on each form depend on the current implementation and
permissions.

  -----------------------------------------------------------------------
  Form                                Purpose
  ----------------------------------- -----------------------------------
  `frmWelcome`                        Welcome screen and language
                                      selection.

  `frmLogin`                          Authenticates a registered user.

  Registration form                   Creates an account and assigns an
                                      available role.

  `frmDashboard`                      Main navigation dashboard for the
                                      applicable account type.

  `frmOrganisationDashboard`          Dashboard intended for community
                                      organisation accounts.

  `frmUserDashboard`                  Dashboard intended for standard
                                      user accounts.

  `frmSurplus`                        Records and manages surplus
                                      produce.

  `frmRecipients`                     Maintains recipient information for
                                      matching and distribution.

  `frmRecommendationEngine`           Displays matching suggestions to
                                      support allocation decisions.

  `frmDistribution`                   Records food distribution and
                                      supports stock updates.

  Report form                         Displays reports and provides
                                      reporting/export functions.

  `frmFoodExchange`                   Access point for food exchange
                                      functionality.

  `frmFoodRequest`                    Supports submitting and viewing
                                      food requests.

  `frmBarterMenu`                     Navigation for barter features.

  `frmBarter`                         Creates an offer including contact
                                      details, offered produce and
                                      quantity, requested produce and
                                      quantity, and community.

  `frmViewBarter`                     Displays barter offers and supports
                                      the confirmation workflow available
                                      to permitted users.

  `frmUserProfile`                    Displays or manages profile
                                      information.

  `frmVitiBot`                        Provides local, prepared-response
                                      assistance.
  -----------------------------------------------------------------------

For forms whose exact class names are not listed, the names displayed in
Visual Studio and in the repository are authoritative.

## User Roles and Permissions

Viti FoodLink is designed around three main roles: **Administrator**,
**Community Organisation**, and **User**. The source code's role checks
determine the actual access granted to each account.

### Administrator

The administrator is responsible for system oversight and restricted
management tasks. Depending on the configured permissions, this can
include: - Accessing administrative navigation. - Reviewing surplus
produce and recipient information. - Accessing recommendation and
distribution workflows. - Recording or overseeing distributions. -
Viewing system reports. - Reviewing system activity and barter records
where available.

### Community Organisation

This role is intended for community groups participating in food
sharing. Its available dashboard and actions depend on the permissions
implemented in the current build.

### User

The standard user role is intended for community members. Depending on
current permission rules, user-facing activities can include: -
Accessing the user dashboard. - Submitting food requests. - Recording
surplus or participating in food exchange where permitted. - Creating
and viewing barter offers. - Managing available profile information. -
Using supported language options and VitiBot.

**Before release:** test with one account per role. Do not assume every
role can open every form.

## Typical Workflows

### Sign in or register

1.  Open the application.
2.  Choose a language if offered on the welcome screen.
3.  Sign in or register a new account.
4.  Continue to the dashboard for that account's role.

### Manage surplus food

1.  Open surplus management if permitted.
2.  Enter produce details and quantity.
3.  Save and verify the record.

### Match recipients and distribute food

1.  Ensure surplus and recipient information is entered.
2.  Open the recommendation engine.
3.  Review suggested matches.
4.  Use the distribution form if permitted.
5.  Verify the distribution record and stock update.

Recommendations are decision-support suggestions and should be reviewed
by a person.

### Submit a food request

1.  Open the food request form.
2.  Complete the required fields.
3.  Submit the request.
4.  Verify the saved request in the relevant view.

### Create a barter offer

1.  Open the barter form.
2.  Enter the person's name and contact number.
3.  Enter offered produce and quantity.
4.  Enter requested produce and quantity.
5.  Enter the community.
6.  Select **Add Barter**.
7.  Verify the offer in the barter records and follow the available
    confirmation process.

### Review reports

1.  Open the report form with an authorised account.
2.  Select available report options or date filters.
3.  Review the displayed information.
4.  Export to CSV if available.

## Database

SQLite provides local data persistence. `DatabaseHelper.vb` manages
connections and database initialization.

The database may contain information for users, surplus produce, barter
offers and confirmation details, food requests, recipients, and
distribution workflows. Confirm the exact schema against the SQL and
database file in the repository before making changes.

### Database location

The current configuration has used a path relative to the application
startup directory:

``` text
Database/VitiFoodLink.db
```

For the portable release, preserve the `Database` folder beside the
executable. Run the application from a folder where the user has write
permission, such as a folder under Documents.

**Back up the database before updating the application.** Replacing it
with a clean database can remove saved accounts, offers, requests, and
other records.

## Languages

Implemented language options include: - **English** - **iTaukei** -
**Fiji Hindi**

Translation coverage may differ by form. `LanguageHelper.vb` maintains
the shared language setting. Test labels, buttons, validation messages,
and success/error messages on every form expected to be translated.

## Run the Application

### Portable Windows release

1.  Obtain the release ZIP from the repository's release location or
    project maintainer.
2.  Extract it to a writable folder, such as one under Documents.
3.  Keep the executable, configuration file, SQLite dependencies,
    architecture folders, and `Database` folder in their expected
    relative locations.
4.  Double-click the application executable.
5.  Sign in with an account configured for the application.

Do not move only the `.exe`; it needs supporting files and its database.
The target framework is .NET Framework 4.7.2, and a compatible runtime
and SQLite native dependencies may be required.

### Run from source

1.  Install Visual Studio with .NET desktop development support.
2.  Clone or download the repository.
3.  Open the `.sln` solution file.
4.  Restore NuGet packages if prompted.
5.  Confirm the SQLite database is in the location expected by
    `DatabaseHelper.vb`.
6.  Build and run the project.

## Build from Source

1.  Back up the source project and SQLite database.
2.  Select `Release` in Visual Studio's build configuration.
3.  Choose **Build → Build Solution**.
4.  Confirm the build succeeds.
5.  Copy the executable, configuration file, required managed/native
    SQLite dependencies, and database folder into a separate release
    directory.
6.  Test the release outside Visual Studio.
7.  Test a freshly extracted ZIP before sharing it.

Never use your only database copy for risky tests.

## Project Structure

The following is an illustrative layout. Actual folders may differ; use
Solution Explorer as the source of truth.

``` text
VitiFoodLink/
├── Database/
│   └── VitiFoodLink.db
├── Forms/
│   ├── frmWelcome
│   ├── frmLogin
│   ├── frmDashboard
│   ├── frmOrganisationDashboard
│   ├── frmUserDashboard
│   ├── frmSurplus
│   ├── frmRecipients
│   ├── frmRecommendationEngine
│   ├── frmDistribution
│   ├── frmFoodExchange
│   ├── frmFoodRequest
│   ├── frmBarterMenu
│   ├── frmBarter
│   ├── frmViewBarter
│   ├── frmUserProfile
│   └── frmVitiBot
├── DatabaseHelper.vb
├── LanguageHelper.vb
├── App.config
├── packages.config
└── [solution and project files]
```

## Testing Checklist

-   [ ] Login accepts valid credentials and rejects invalid credentials.
-   [ ] Registration validates required fields and password
    confirmation.
-   [ ] Each role sees only its permitted features.
-   [ ] Surplus produce can be saved and reviewed.
-   [ ] Recipient information can be saved and reviewed.
-   [ ] Recommendation results display as expected.
-   [ ] Distribution updates the appropriate records and stock.
-   [ ] Food requests can be submitted and viewed.
-   [ ] Barter offers can be created and viewed.
-   [ ] Barter confirmation follows intended permission rules and
    preserves confirmation information.
-   [ ] Reports and CSV export work where enabled.
-   [ ] Language selection updates supported forms and messages.
-   [ ] The extracted ZIP launches without Visual Studio.
-   [ ] Existing records remain after restarting.
-   [ ] A separate database backup exists.
-   [ ] Documentation matches the final build.

## Security and Data Notes

-   Do not commit real personal information, phone numbers, passwords,
    or a database containing private user data to a public GitHub
    repository.
-   If the database contains real users or test credentials, exclude it
    from the public repository and consider distributing a sanitized
    sample database.
-   Review `.gitignore` for build output and local files such as `bin/`,
    `obj/`, temporary files, and backups.
-   Use test accounts for demonstrations.
-   Review the password-storage implementation before using the
    application with real users. Do not assume passwords are securely
    hashed unless the code confirms this.
-   Back up the database before schema migrations or release updates.

## Future Improvements

Possible future enhancements include: - A guided Windows installer and
uninstaller. - Storing the database in the user's application-data
directory instead of beside the executable. - Broader multilingual
coverage across all forms. - Stronger password hashing and
account-security controls. - Automated tests for role permissions and
database operations. - A central API and shared database for multiple
computers. A local SQLite file is not, by itself, a shared multi-device
service. - Better audit logs, recovery tools, accessibility, and
usability testing.

These are potential improvements, not claims that they are already
implemented.

## Academic Project Note

Viti FoodLink was developed as a university software engineering project
to demonstrate desktop application development, database integration,
role-aware workflows, food-sharing processes, and community barter
functionality in a Fijian context.

It is intended for academic demonstration and evaluation. Before using
it to manage real community food distribution, review security, privacy,
backups, access control, and operational requirements.

------------------------------------------------------------------------

**Viti FoodLink --- Share surplus. Support communities. Make food go
further.**
