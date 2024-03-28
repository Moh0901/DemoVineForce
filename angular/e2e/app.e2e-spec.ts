import { DemoVineForceTemplatePage } from './app.po';

describe('DemoVineForce App', function() {
  let page: DemoVineForceTemplatePage;

  beforeEach(() => {
    page = new DemoVineForceTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
