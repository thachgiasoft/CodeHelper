/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package parsetool.dataview.models;

import parsetool.models.common.TokenPair;

/**
 *
 * @author cqy
 */
public class Table extends TokenPair{
    private String text;

    /**
     * @return the text
     */
    public String getText() {
        return text;
    }

    /**
     * @param text the text to set
     */
    public void setText(String text) {
        this.text = text;
    }
}
