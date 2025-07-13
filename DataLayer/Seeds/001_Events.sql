begin;

truncate table events;

insert into events (name, slug, begins_at, ends_at, description)
values ('Best of Utrecht - Highlights of the LMHI 2025', 'best-of-utrecht-highlights-of-the-lmhi-2025', '2025-05-30T02:00:00Z', '2025-05-30T04:30:00Z', 'Just came back from Utrecht where I took part in the LMHI conference (Liga Medicorum Homoeopathica Internationalis).

Happy to announce the free webinar "Best of Utrecht - Highlights of LMHI 2025"

Scheduled on Saturday May 24th 4pm Central European time.

Meet the finest speakers of my personal choice and join us to feel the vibe of this exceptional conference!'),
('Dr Asher Shaikh webinar: Policystic ovary and infertility cases - combining German New Medicine and Homeopathy', 'dr-asher-shaikh-webinar-policystic-ovary-and-infertility-cases-combining-german-new-medicine-and-homeopathy', '2025-04-27T15:00:00Z', '2025-04-27T16:30:00Z', '[EN] We invite everybody to take part in Dr Asher Shaikh''s webinar "Policystic ovary and infertility cases - combining German New Medicine and Homeopathy". The lecture will be held in English and consecutively translated into Polish. The webinar is free of charge. The webinar is organised in honorary cooperation with the Polish Homeopathic Society and the Polish Society of Homeopathic Doctors and Pharmacists.

Notice: The webinar will be available only for registered users only. It will be hosted on the Zoom platform through our website homeosapiens.eu. The page will ask you to set a password for your account. If you already have an account on our website, there’s no need to create another account. Use the e-mail address and password you had set at registration. If you encounter any problems, please contact us by email at homeo.zoom@gmail.com.

Dr Asher Shaikh (India) – a homeopathic doctor with over 25 years of clinical experience. He is the Director of Asher Clinics – a network of 12 clinics in Mumbai, Pune, Dubai, and Nasik – and a mentor in German New Medicine, which he has taught in Dubai, India, Austria, and Israel. He currently serves as a professor at the Homoeopathic Medical College in Nasik and as the Director of Viveda Resort – an innovative holistic health center. He is the former president of the Indian Institute of Homoeopathic Physicians. Dr. Shaikh specializes in reversing autoimmune disorders.

Website: www.asherclinic.com

Instagram: @asherhomoeopathy @doctor.ashar');

commit;
