(defglobal ?*recommendation* = nil)

(deftemplate recommendation
    (slot text)
)

(deftemplate user-preference
   (slot genre)
   (slot mood)
   (slot time)
)

(defrule ask-user
   =>
   (printout t "What Type Of Movies Do You Prefer? (action / romance / comedy / horror / scifi): " crlf)
   (bind ?genre (read))
   (printout t "Current Mood? (happy / sad / bored): " crlf)
   (bind ?mood (read))
   (printout t "How Much Time Can You Spare For Watching? (short / medium / long): " crlf)
   (bind ?time (read))
   (assert (user-preference (genre ?genre) (mood ?mood) (time ?time)))
)

(defrule recommend-action
   (user-preference (genre action) (mood happy|sad|bored) (time short|medium|long))
   =>
(bind ?*recommendation* "We Recommend: Mad Max: Fury Road")
   (assert (recommendation (text ?*recommendation*)))
)

(defrule recommend-romance
   (user-preference (genre romance) (mood happy|sad|bored) (time short|medium|long))
   =>
   (printout t "We Recommend: Nour Ainy (starring Omar w salma, Menna Shalaby" crlf)
(assert (recommendation (text "We Recommend: Nour Ainy (starring Omar w salma, Menna Shalaby)")))
)

(defrule recommend-comedy
   (user-preference (genre comedy) (mood happy|sad|bored) (time short|medium|long))
   =>
   (printout t "We Recommend: Mafesh Fayda (starring: Mustafa Amar, Basma)" crlf)
(assert (recommendation (text "We Recommend: Mafesh Fayda (starring: Mustafa Amar, Basma)")))
)

(defrule recommend-horror
   (user-preference (genre horror) (mood happy|sad|bored) (time short|medium|long))
   =>
   (printout t "We Recommend: Camp (starring: Unknown actors, Hesham Ramzy" crlf)
(assert (recommendation (text "We Recommend: Camp (starring: Unknown actors, Hesham Ramzy)")))
)

(defrule recommend-scifi
   (user-preference (genre scifi) (mood happy|sad|bored) (time short|medium|long))
   =>
   (printout t "We Recommend: Cima Ali Baba (starring: Ahmed Meky, Amy Samir Ghanem)" crlf)
(assert (recommendation (text "We Recommend: Cima Ali Baba (starring: Ahmed Meky, Amy Samir Ghanem)")))
)