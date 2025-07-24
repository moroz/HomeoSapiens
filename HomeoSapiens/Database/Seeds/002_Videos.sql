begin;

truncate table videos;

insert into videos (name_en, description_en, slug, youtube_id)
values
('Why the Organon is still important', 'Dr Sanjay Modi and Dr Robert Zawiślak discuss Hahnemann''s classic
and why it is still valid today - maybe more than ever.', 'why-the-organon-is-still-important', 'QtY7rthbWb8'),
('Dr Herman Jeggels on peripheral arterial circulation, coeliac trunk and Secale cornutum', 'South Africa''s Dr. Jeggels discusses the importance of clinical observation 
in selecting the right homeopathic remedy. Secale cornutum is often 
associated with peripheral arterial disease, yet not often
considered in abdominal complaints.', 'dr-herman-jeggels-on-peripheral-arterial-circulation', 'laEvtXIX0Sk');

commit;