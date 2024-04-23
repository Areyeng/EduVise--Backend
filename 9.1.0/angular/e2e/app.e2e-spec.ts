import { EduViseTemplatePage } from './app.po';

describe('EduVise App', function() {
  let page: EduViseTemplatePage;

  beforeEach(() => {
    page = new EduViseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
