select top 1 * from SurveyQuestion where surveyType = 'Check box' order by Id desc
SELECT answer FROM SurveyAnswer WHERE(questionId = 7)

select TOP 1 * from SurveyQuestion sq, SurveyAnswer sa
where sq.Id=sa.questionId
and surveyType = 'Combo box' order by sq.Id desc

SELECT answer FROM SurveyAnswer WHERE (Id = 28)

delete from SurveyQuestion where Id ='16'
delete from SurveyAnswer
delete from SurveyInfo
delete from SurveyInfo