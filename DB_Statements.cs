namespace DisciplesMerger
{
    public static class DB_Statements
    {
        public const string INSERT_ATTENDANCE = "INSERT INTO `attendance`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_events_guid`,`fk_sessions_guid`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_events_guid,@fk_sessions_guid);";
        public const string INSERT_CONTACTS = "INSERT INTO `contacts`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_workers_guid`,`date`,`duration`,`type`,`studytype`,`fk_studyseries_guid`,`studynumber`,`fk_studytopics_guid`,`studytopicother`,`completed`,`notes`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_workers_guid,@date,@duration,@type,@studytype,@fk_studyseries_guid,@studynumber,@fk_studytopics_guid,@studytopicother,@completed,@notes);";
        public const string INSERT_DECISIONS = "INSERT INTO `decisions`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_registrations_guid`,`fk_contacts_guid`,`fk_sessions_guid`,`decision`,`decisionother`,`decisioncategory`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_registrations_guid,@fk_contacts_guid,@fk_sessions_guid,@decision,@decisionother,@decisioncategory);";
        public const string INSERT_EVENTS = "INSERT INTO `events`(`guid`,`timestamp`,`fk_churches_guid`,`fk_workers_guid`,`fk_workers_guid2`,`type`,`title`,`abbreviation`,`color`,`description`,`date`,`presenter`,`venue`,`street`,`city`,`state`,`postal`,`country`,`coordinates`,`notes`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_workers_guid,@fk_workers_guid2,@type,@title,@abbreviation,@color,@description,@date,@presenter,@venue,@street,@city,@state,@postal,@country,@coordinates,@notes);";
        public const string INSERT_FILTERS = "INSERT INTO `filters`(`guid`,`timestamp`,`fk_workers_guid`,`name`,`andor`,`categories`,`columns`,`operators`,`queries`) VALUES (@guid,@timestamp,@fk_workers_guid,@name,@andor,@categories,@columns,@operators,@queries);";
        public const string INSERT_GROUPS = "INSERT INTO `groups`(`guid`,`timestamp`,`fk_workers_guid`,`name`,`type`,`guids`) VALUES (@guid,@timestamp,@fk_workers_guid,@name,@type,@guids);";
        public const string INSERT_INTERESTS = "INSERT INTO `interests`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`interest`,`interestother`,`interestcategory`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@interest,@interestother,@interestcategory);";
        public const string INSERT_JOURNALENTRIES = "INSERT INTO `journalentries`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_events_guid`,`fk_smallgroups_guid`,`type`,`title`,`date`,`duration`,`notes`,`completed`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_events_guid,@fk_smallgroups_guid,@type,@title,@date,@duration,@notes,@completed);";
        public const string INSERT_METADATA = "INSERT INTO `metadata`(`guid`,`timestamp`,`version`,`shared`,`account_id`,`lastsync`,`needssync`,`name`,`description`,`street`,`unit`,`city`,`state`,`postal`,`country`,`coordinates`,`phone1`,`phone2`,`email`,`notes`) VALUES (@guid,@timestamp,@version,@shared,@account_id,@lastsync,@needssync,@name,@description,@street,@unit,@city,@state,@postal,@country,@coordinates,@phone1,@phone2,@email,@notes);";
        public const string INSERT_NAMES = "INSERT INTO `names`(`guid`,`timestamp`,`fk_churches_guid`,`fk_workers_guid`,`fk_workers_guid2`,`fk_smallgroups_guid`,`type`,`level`,`status`,`agegroup`,`marital`,`ethnicity`,`ethnicityother`,`language`,`languageother`,`religion`,`religionother`,`homechurch`,`attendingchurch`,`baptismdate`,`leadsource`,`firstcontact`,`title`,`firstname`,`lastname`,`street`,`unit`,`city`,`state`,`postal`,`country`,`coordinates`,`phone1`,`phone1type`,`phone2`,`phone2type`,`email`,`gender`,`birthdate`,`referrer`,`visitday`,`visittime`,`autoschedule`,`notes`,`confidential`,`user`,`password`,`permissions`,`color`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_workers_guid,@fk_workers_guid2,@fk_smallgroups_guid,@type,@level,@status,@agegroup,@marital,@ethnicity,@ethnicityother,@language,@languageother,@religion,@religionother,@homechurch,@attendingchurch,@baptismdate,@leadsource,@firstcontact,@title,@firstname,@lastname,@street,@unit,@city,@state,@postal,@country,@coordinates,@phone1,@phone1type,@phone2,@phone2type,@email,@gender,@birthdate,@referrer,@visitday,@visittime,@autoschedule,@notes,@confidential,@user,@password,@permissions,@color);";
        public const string INSERT_REGISTRATIONS = "INSERT INTO `registrations`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_events_guid`,`fk_workers_guid`,`ticketnumber`,`advertising`,`notes`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_events_guid,@fk_workers_guid,@ticketnumber,@advertising,@notes);";
        public const string INSERT_RELATIONSHIPS = "INSERT INTO `relationships`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_names_guid2`,`type`,`sort`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_names_guid2,@type,@sort);";
        public const string INSERT_SESSIONS = "INSERT INTO `sessions`(`guid`,`timestamp`,`fk_churches_guid`,`fk_events_guid`,`night`,`date`,`title`,`subject`,`venue`,`presenter`,`fk_workers_guid`,`fk_lessons_guid`,`materials`,`notes`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_events_guid,@night,@date,@title,@subject,@venue,@presenter,@fk_workers_guid,@fk_lessons_guid,@materials,@notes);";
        public const string INSERT_SMALLGROUPS = "INSERT INTO `smallgroups`(`guid`,`timestamp`,`fk_churches_guid`,`fk_names_guid`,`fk_workers_guid`,`name`,`description`,`location`,`street`,`unit`,`city`,`state`,`postal`,`country`,`coordinates`,`day`,`time`,`materials`,`notes`) VALUES (@guid,@timestamp,@fk_churches_guid,@fk_names_guid,@fk_workers_guid,@name,@description,@location,@street,@unit,@city,@state,@postal,@country,@coordinates,@day,@time,@materials,@notes);";
        public const string INSERT_SYNCLOGS = "INSERT INTO `synclogs`(`timestamp`,`fk_churches_guid`,`tablename`,`fk_guid`,`action`) VALUES (@timestamp,@fk_churches_guid,@tablename,@fk_guid,@action);";

        public const string READ_ATTENDANCE = "SELECT * FROM attendance";
        public const string READ_CONTACTS = "SELECT * FROM contacts";
        public const string READ_DECISIONS = "SELECT * FROM decisions";
        public const string READ_EVENTS = "SELECT * FROM events";
        public const string READ_FILTERS = "SELECT * FROM filters";
        public const string READ_GROUPS = "SELECT * FROM groups";
        public const string READ_INTERESTS = "SELECT * FROM interests";
        public const string READ_JOURNALENTRIES = "SELECT * FROM journalentries";
        public const string READ_METADATA = "SELECT * FROM metadata";
        public const string READ_NAMES = "SELECT * FROM names";
        public const string READ_REGISTRATIONS = "SELECT * FROM registrations";
        public const string READ_RELATIONSHIPS = "SELECT * FROM relationships";
        public const string READ_SESSIONS = "SELECT * FROM sessions";
        public const string READ_SMALLGROUPS = "SELECT * FROM smallgroups";
        public const string READ_SYNCLOGS = "SELECT * FROM synclogs";
    }
}
