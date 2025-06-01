import { abpcqrstestTemplatePage } from './app.po';

describe('abpcqrstest App', function() {
  let page: abpcqrstestTemplatePage;

  beforeEach(() => {
    page = new abpcqrstestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
